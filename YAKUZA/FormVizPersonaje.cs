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
    public partial class FormVizPersonaje : Form
    {
        #region 1. Variabilele declarate.
        bool flagClose = false;
        private int cycleCNT = 0;
        private static string constr;
        public string Constr { set { constr = value; } }

        public struct character
        {
            public int ID;
            public string nume, locatie, path_poza;
            public int cod_familie, cod_stil, nivel, bani;

            public character(int id, string nm, string loc, int cf, int cs, int lvl, int mny, string path)
            {
                ID = id;
                nume = nm; locatie = loc; path_poza = path;
                cod_familie = cf; cod_stil = cs; nivel = lvl; bani = mny;
            }
        }
        private List<character> characters = new List<character>();

        public struct stylebond
        {
            public int cod_stil;
            public string nume_stil;
            public stylebond(int cs, string ns)
            {
                cod_stil = cs; nume_stil = ns;
            }
        }
        List<stylebond> stylebonds = new List<stylebond>();

        public struct familybond
        {
            public int cod_familie;
            public string nume_familie;
            public familybond(int cf, string nf)
            {
                cod_familie = cf; nume_familie = nf;
            }

        }
        List<familybond> familybonds = new List<familybond>();
        #endregion
        public FormVizPersonaje()
        {
            InitializeComponent();
        }

        #region 2. Functiile de initializare si de obtinere a informatiilor din baza de date
        private void GetInfoFromDB()
        {
            flagClose = false;
            using(SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Personaje.*, Stiluri.Nume, Familii.Nume FROM Personaje, Stiluri, Familii" +
                    " WHERE Personaje.Cod_Stil = Stiluri.Cod_Stil AND Personaje.Cod_Familie = Familii.Cod_Familie", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    character ch = new character((int)dr[0], (string)dr[1], (string)dr[2], (int)dr[3], (int)dr[4], (int)dr[5], (int)dr[6], (string)dr[7]);
                    characters.Add(ch);
                    stylebond sty = new stylebond((int)dr[4], (string)dr[8]);
                    stylebonds.Add(sty);
                    familybond fml = new familybond((int)dr[3], (string)dr[9]);
                    familybonds.Add(fml);
                }
                cmd.Dispose();
                dr.Dispose();
                conn.Close();

            }
            if (characters.Count == 0)
            {
                flagClose = true;
            }
        }

        private void InitializeState()
        {
            string path;
            textBoxID.Text = characters[cycleCNT].ID.ToString();
            labelNume.Text = characters[cycleCNT].nume; labelLocatie.Text = characters[cycleCNT].locatie;
            labelFamilie.Text = familybonds[cycleCNT].nume_familie; labelStil.Text = stylebonds[cycleCNT].nume_stil; 
            labelNivel.Text = characters[cycleCNT].nivel.ToString() + @"/20"; labelBani.Text = characters[cycleCNT].bani.ToString() + @" yen";

            if (File.Exists(Application.StartupPath + @"\PersPhotoResources\" + characters[cycleCNT].path_poza))
            {
                label7.Visible = false;
                path = String.Format(Application.StartupPath + @"\PersPhotoResources\" + characters[cycleCNT].path_poza);
                using (Image sourceImg = Image.FromFile(path))
                {
                    Image cloneImg = new Bitmap(sourceImg.Width, sourceImg.Height, sourceImg.PixelFormat);
                    using (var copy = Graphics.FromImage(cloneImg))
                        copy.DrawImage(sourceImg, 0, 0);
                    pictureBoxChar.InitialImage = null;
                    pictureBoxChar.Image = cloneImg;
                }
            }
            else
            {
                pictureBoxChar.InitialImage = null;
                pictureBoxChar.Image = null;
                label7.Text = "N / A";
                label7.Visible = true;
            }

            textBoxCnt.Text = (cycleCNT + 1).ToString() + @"/" + characters.Count.ToString();
        }
        #endregion
        private void FormVizPersonaje_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.y0;
        redo:
            GetInfoFromDB();
            if (!flagClose)
                InitializeState();
            else
            {
                if (MessageBox.Show("Baza de date nu contine nici un personaj. \nDoriti sa creati unul nou?", "EROARE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    FormAddPersonaje fAP = new FormAddPersonaje();
                    fAP.Constr = constr;
                    fAP.ShowDialog();
                    fAP.Dispose();
                    goto redo;

                }
                else
                    this.Close();
            }
        }

        #region 3. Comenzile butoanelor
        private void buttonAddPers_Click(object sender, EventArgs e)
        {
            FormAddPersonaje fAP = new FormAddPersonaje();
            fAP.Constr = constr;
            fAP.ShowDialog();
            fAP.Dispose();

            characters.Clear();
            stylebonds.Clear();
            familybonds.Clear();
            GetInfoFromDB();
            InitializeState();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti personajul selectat?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM [Personaje] WHERE ID_Personaj = @id", conn);
                    cmd.Parameters.AddWithValue("id", characters[cycleCNT].ID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    if (characters[cycleCNT].path_poza != "0")
                        File.Delete(Application.StartupPath + @"\PersPhotoResources\" + characters[cycleCNT].path_poza);

                    conn.Close();
                }
                MessageBox.Show("Stergere realizata cu succes!", "DELETE CHECK: DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                characters.Clear();
                stylebonds.Clear();
                familybonds.Clear();
                cycleCNT = 0;
                GetInfoFromDB();
                if (!flagClose)
                    InitializeState();
                else
                {
                    MessageBox.Show("Toate personajele au fost sterse, formularul va fi inchis.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            FormModPersonaje fMP = new FormModPersonaje();
            fMP.chara = new character(characters[cycleCNT].ID, characters[cycleCNT].nume, characters[cycleCNT].locatie, characters[cycleCNT].cod_familie, characters[cycleCNT].cod_stil, characters[cycleCNT].nivel, characters[cycleCNT].bani, characters[cycleCNT].path_poza);
            fMP.sty = new stylebond(stylebonds[cycleCNT].cod_stil, stylebonds[cycleCNT].nume_stil);
            fMP.fam = new familybond(familybonds[cycleCNT].cod_familie, familybonds[cycleCNT].nume_familie);
            fMP.Constr = constr;
            fMP.img = pictureBoxChar.Image;
            fMP.ShowDialog();

            characters.Clear();
            stylebonds.Clear();
            familybonds.Clear();
            GetInfoFromDB();
            InitializeState();
        }

        private void AllButtonAdv_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            char op = bt.Text[0];
            if (op == '<') //cand este apasat butonul cu textul "<"
            {
                cycleCNT--;
                if (cycleCNT < 0)
                    cycleCNT = characters.Count - 1;
                InitializeState();
            }
            else if (op == '>') //cand este apasat butonul cu textul ">"
            {
                cycleCNT++;
                if (cycleCNT == characters.Count)
                    cycleCNT = 0;
                InitializeState();
            }
        }
        #endregion
    }
}
