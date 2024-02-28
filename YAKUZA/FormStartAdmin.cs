using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace YAKUZA
{
    public partial class FormStartAdmin : Form
    {
        #region 1. Variabilele declarate
        private static string constr;
        public string Constr { set { constr = value; } }
        #endregion
        public FormStartAdmin()
        {
            InitializeComponent();
        }

        private void FormStartAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakuzaDataSet1.Familii' table. You can move, or remove it, as needed.
            this.familiiTableAdapter.Fill(this.yakuzaDataSet1.Familii);
            // TODO: This line of code loads data into the 'yakuzaDataSet1.Stiluri' table. You can move, or remove it, as needed.
            this.stiluriTableAdapter.Fill(this.yakuzaDataSet1.Stiluri);
            // TODO: This line of code loads data into the 'yakuzaDataSet.Personaje' table. You can move, or remove it, as needed.
            this.personajeTableAdapter.Fill(this.yakuzaDataSet.Personaje); 
            this.Icon = Properties.Resources.y0;

        }

        #region 2. Controalele Tabului 1
        private void buttonPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath, "Path:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(constr, "String:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Asta va sterge toate datele din baza de date si o va reinitializa cu valori implicite." +
                " \nSunteti sigut ca doriti asta?", "AVERISMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    //STERGERE
                    SqlCommand cmd = new SqlCommand("DELETE FROM [Personaje]", conn); cmd.ExecuteNonQuery(); cmd.Dispose();
                    cmd = new SqlCommand("DELETE FROM [Stiluri]", conn); cmd.ExecuteNonQuery(); cmd.Dispose();
                    cmd = new SqlCommand("DELETE FROM [Familii]", conn); cmd.ExecuteNonQuery(); cmd.Dispose();

                    string[] photoFiles = Directory.GetFiles(Application.StartupPath + @"\PersPhotoResources\");
                    foreach (string ph in photoFiles)
                        File.Delete(ph);

                    //RESEED
                    cmd = new SqlCommand("DBCC CHECKIDENT('Personaje', RESEED, 0)", conn); cmd.ExecuteNonQuery(); cmd.Dispose();
                    cmd = new SqlCommand("DBCC CHECKIDENT('Stiluri', RESEED, -1)", conn); cmd.ExecuteNonQuery(); cmd.Dispose();
                    cmd = new SqlCommand("DBCC CHECKIDENT('Familii', RESEED, -1)", conn); cmd.ExecuteNonQuery(); cmd.Dispose();

                    string line;
                    char[] parser = { '\t' };

                    //Reintroducerea datelor: Stiluri
                    StreamReader sr = new StreamReader(Application.StartupPath + @"\..\..\InitialValues\Stiluri.txt");
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] elems = line.Split(parser);
                        SqlCommand cmdInsert = new SqlCommand("INSERT INTO [Stiluri](Nume, Viteza, Putere, Rank, Procent, Descriere) VALUES (@nm, @vt, @pt, @rk, @proc, @desc)", conn);
                        cmdInsert.Parameters.AddWithValue("nm", elems[0].Trim());
                        cmdInsert.Parameters.AddWithValue("vt", Convert.ToInt32(elems[1].Trim())); cmdInsert.Parameters.AddWithValue("pt", Convert.ToInt32(elems[2].Trim()));
                        cmdInsert.Parameters.AddWithValue("rk", Convert.ToInt32(elems[3].Trim())); cmdInsert.Parameters.AddWithValue("proc", Convert.ToInt32(elems[4].Trim()));
                        cmdInsert.Parameters.AddWithValue("desc", elems[5].Trim());
                        cmdInsert.ExecuteNonQuery(); cmd.Dispose();
                    }
                    sr.Close(); sr.Dispose();

                    //Reintroducerea datelor: Familii
                    sr = new StreamReader(Application.StartupPath + @"\..\..\InitialValues\Familii.txt");
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] elems = line.Split(parser);
                        SqlCommand cmdInsert = new SqlCommand("INSERT INTO [Familii](Nume, Lider, Nr_Membri, Afiliere) VALUES(@nm, @ld, @mem, @af)", conn);
                        cmdInsert.Parameters.AddWithValue("nm", elems[0].Trim()); cmdInsert.Parameters.AddWithValue("ld", elems[1].Trim());
                        cmdInsert.Parameters.AddWithValue("mem", Convert.ToInt32(elems[2].Trim()));
                        cmdInsert.Parameters.AddWithValue("af", elems[3].Trim());
                        cmdInsert.ExecuteNonQuery(); cmd.Dispose();
                    }
                    sr.Close(); sr.Dispose();

                    //Reintroducerea datelor: Personaje
                    sr = new StreamReader(Application.StartupPath + @"\..\..\InitialValues\Personaje.txt");
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] elems = line.Split(parser);
                        SqlCommand cmdInsert = new SqlCommand("INSERT INTO [Personaje](Nume, Locatie, Cod_Familie, Cod_Stil, Nivel, Bani, Path_Poza) VALUES(@nm, @loc, @cf, @cs, @nvl, @bni, @path)", conn);
                        cmdInsert.Parameters.AddWithValue("nm", elems[0].Trim()); cmdInsert.Parameters.AddWithValue("loc", elems[1].Trim());
                        cmdInsert.Parameters.AddWithValue("cf", Convert.ToInt32(elems[2].Trim())); cmdInsert.Parameters.AddWithValue("cs", Convert.ToInt32(elems[3].Trim()));
                        cmdInsert.Parameters.AddWithValue("nvl", Convert.ToInt32(elems[4].Trim())); cmdInsert.Parameters.AddWithValue("bni", Convert.ToInt32(elems[5].Trim()));
                        cmdInsert.Parameters.AddWithValue("path", elems[6].Trim());
                        cmdInsert.ExecuteNonQuery(); cmdInsert.Dispose();

                        File.Copy(Application.StartupPath + @"\..\..\InitialValues\PozePersonaje\" + elems[6].Trim(), Application.StartupPath + @"\PersPhotoResources\" + elems[6].Trim(), true);

                    }
                    sr.Close(); sr.Dispose();
                    conn.Close();
                }
                MessageBox.Show("Baza de date a fost adusa la starea initiala.", "REINITIALIZE CHECK: DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Resetarea grid-urilor
                personajeTableAdapter.Update(yakuzaDataSet.Personaje);
                personajeTableAdapter.Fill(yakuzaDataSet.Personaje);
                familiiTableAdapter.Update(yakuzaDataSet1.Familii);
                familiiTableAdapter.Fill(yakuzaDataSet1.Familii);
                stiluriTableAdapter.Update(yakuzaDataSet1.Stiluri);
                stiluriTableAdapter.Fill(yakuzaDataSet1.Stiluri);
            }
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath);
        }

        private void buttonSite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Operatiunea va va deschide browser-ul implicit pentru a intra pe site. " +
                "Doriti sa continuati? \n(cunostinte in limba japoneza ar putea fi necesare.)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start("https://ryu.sega-online.jp/special/character/");
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            string info = "YAKUZA Character Editor, v. Alpha 0.9 - Kohryu\n\n\nAplicatia aceasta a fost creata pentru proba practica a atestatului de informatica din 2022." +
                "\nProgramul poate retine informatii despre un personaj din franchiza Yakuza, incluzand date generale, precum orasul in care sta in prezent,\ndar si date despre stilul " +
                "acestuia(modul in care acesta se lupta) si familia/asociatia/clanul de provenienta. Vine inclus cu un MP3 Player.\n\nAplicatia a fost realizata in Visual Studio 2022, in limbajul de programare C#, " +
                "de catre Razvan-Fabian Budasu.";
            MessageBox.Show(info, "Informatii:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region 3. Controalele Tabului 2
        private void buttonUpdatePers_Click(object sender, EventArgs e)
        {
            personajeTableAdapter.Update(yakuzaDataSet.Personaje);
        }

        private void buttonPhotoOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\PersPhotoResources\");
        }
        #endregion

        #region 4. Controalele Tabului 3
        private void buttonUpdateSty_Click(object sender, EventArgs e)
        {
            stiluriTableAdapter.Update(yakuzaDataSet1.Stiluri);
        }
        #endregion

        #region 5. Controalele Tabului 4
        private void buttonUpdateFam_Click(object sender, EventArgs e)
        {
            familiiTableAdapter.Update(yakuzaDataSet1.Familii);
        }
        #endregion

        private void tabPageTools_Click(object sender, EventArgs e)
        {

        }
    }
}
