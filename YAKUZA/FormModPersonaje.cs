using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace YAKUZA
{
    public partial class FormModPersonaje : Form
    {
        #region 1. Variabilele declarate
        public Image img;
        public FormVizPersonaje.character chara;
        public FormVizPersonaje.stylebond sty;
        public FormVizPersonaje.familybond fam;
        private static string constr;
        public string Constr { set { constr = value; } }
        string photo = "0"; //0 - nemodificat, "" - sters, "..." - modificat
        #endregion
        public FormModPersonaje()
        {
            InitializeComponent();
        }

        #region 2. Initializarea datelor primite din formularul mama
        private void InitializeState()
        {
            textBoxName.Text = chara.nume; textBoxLocatie.Text = chara.locatie;
            comboBoxFam.Text = fam.nume_familie; comboBoxStil.Text = sty.nume_stil;
            comboBoxFam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStil.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxNvl.Text = chara.nivel.ToString(); textBoxBani.Text = chara.bani.ToString();
            pictureBox1.Image = img;
        }
        #endregion
        private void FormModPersonaje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakuzaDataSet.Stiluri' table. You can move, or remove it, as needed.
            this.stiluriTableAdapter.Fill(this.yakuzaDataSet.Stiluri);
            // TODO: This line of code loads data into the 'yakuzaDataSet.Familii' table. You can move, or remove it, as needed.
            this.familiiTableAdapter.Fill(this.yakuzaDataSet.Familii);
            InitializeState();
            this.Icon = Properties.Resources.y0;
        }
        #region 3. Comenzile butoanelor
        private void buttonChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photo = ofd.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(photo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nIncercati alta fotografie!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            photo = "";
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca doriti sa modificati datele acestui personaj?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBoxName.Text == "" || textBoxLocatie.Text == "" || textBoxNvl.Text == "" || textBoxBani.Text == "")
                {
                    MessageBox.Show("Date invalide. Va rugam sa va verificati casetele de text.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE [Personaje] SET Nume = @nm, Locatie = @loc, Cod_Familie = @cf, Cod_Stil = @cs, Nivel = @nvl, Bani = @bni WHERE ID_Personaj = @id", conn);
                    cmd.Parameters.AddWithValue("id", chara.ID);
                    cmd.Parameters.AddWithValue("nm", textBoxName.Text); cmd.Parameters.AddWithValue("loc", textBoxLocatie.Text);
                    cmd.Parameters.AddWithValue("cf", (int)comboBoxFam.SelectedValue); cmd.Parameters.AddWithValue("cs", (int)comboBoxStil.SelectedValue);
                    cmd.Parameters.AddWithValue("nvl", Math.Min(Convert.ToInt32(textBoxNvl.Text), 20)); cmd.Parameters.AddWithValue("bni", (int)Math.Min(Convert.ToInt64(textBoxBani.Text), int.MaxValue));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    if (photo != "" && photo != "0")
                    {
                        cmd = new SqlCommand("UPDATE [Personaje] SET Path_Poza = @ph WHERE ID_Personaj = @id", conn);
                        cmd.Parameters.AddWithValue("id", chara.ID);
                        cmd.Parameters.AddWithValue("ph", (chara.ID + ".png"));
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        File.Copy(photo, Application.StartupPath + @"\PersPhotoResources\" + chara.ID + @".png", true);
                    }
                    else if (photo == "")
                    {
                        cmd = new SqlCommand("UPDATE [Personaje] SET Path_Poza = @ph WHERE ID_Personaj = @id", conn);
                        cmd.Parameters.AddWithValue("id", chara.ID);
                        cmd.Parameters.AddWithValue("ph", 0);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        File.Delete(Application.StartupPath + @"\PersPhotoResources\" + chara.ID + @".png");
                    }
                    conn.Close();
                }
                MessageBox.Show("Modificare realizata cu succes!", "UPDATE CHECK: DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion

        #region 4. Functii de control, pentru textbox-uri
        private void textBoxNvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxBani_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
