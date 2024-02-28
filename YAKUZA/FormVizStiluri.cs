using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace YAKUZA
{
    public partial class FormVizStiluri : Form
    {
        #region 1. Variabilele definite
        private int cycleCNT = 0;
        private int strengthDraw = -1, speedDraw = -1;
        private static string constr;
        public string Constr { set { constr = value; } }

        public struct style
        {
            public int cod_stil;
            public string nume, descriere;
            public int viteza, putere, rank, procent;

            public style(int cs, string nm, int vit, int put, int rnk, int proc, string desc)
            {
                cod_stil = cs;
                nume = nm; descriere = desc;
                viteza = vit; putere = put; rank = rnk; procent = proc;
            }
        }
        List<style> styles = new List<style>();
        bool flagClose = false;
        #endregion
        public FormVizStiluri()
        {
            InitializeComponent();
        }

        #region 2. Initializare si obtinere date din BD
        private void GetInfoFromDB()
        {
            flagClose = false;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Stiluri] WHERE Cod_Stil > 0", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    styles.Add(new style((int)dr[0], (string)dr[1], (int)dr[2], (int)dr[3], (int)dr[4], (int)dr[5], (string)dr[6]));
                }
                dr.Dispose();
                cmd.Dispose();
                conn.Close();
            }
            if (styles.Count == 0)
                flagClose = true;
        }

        private void InitializeState()
        {
            textBoxStyle.Text = styles[cycleCNT].nume;
            labelCompletion.Text = styles[cycleCNT].procent + "%";
            labelStr.Text = styles[cycleCNT].putere + "/100";
            labelSpe.Text = styles[cycleCNT].viteza + "/100";
            textBoxPg.Text = (cycleCNT + 1) + "/" + styles.Count;
            textBoxID.Text = styles[cycleCNT].cod_stil.ToString();

            switch (styles[cycleCNT].rank)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\lightorb.png");
                    pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\noorb.png");
                    break;
                case 2:
                    pictureBox1.Image = pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\lightorb.png");
                    pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\noorb.png");
                    break;
                case 3:
                    pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\lightorb.png");
                    pictureBox4.Image = pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\noorb.png");
                    break;
                case 4:
                    pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\lightorb.png");
                    pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\noorb.png");
                    break;
                case 5:
                    pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\lightorb.png");
                    break;
                default:
                    pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\..\..\IcoResources\noorb.png");
                    break;
            }

            strengthDraw = styles[cycleCNT].putere;
            speedDraw = styles[cycleCNT].viteza;
            panelSpeed.Invalidate(false);
            panelStrength.Invalidate(false);
        }
        #endregion
        private void FormVizStiluri_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.y0;
        redo:
            GetInfoFromDB();
            if (!flagClose)
                InitializeState();
            else
            {
                if (MessageBox.Show("Baza de date nu contine nici un stil. Doriti sa creati unul?", "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FormAddStiluri fAS = new FormAddStiluri();
                    fAS.Constr = constr;
                    fAS.ShowDialog();
                    goto redo;
                }
                else
                    this.Close();
            }
        }

        #region 3. Desenare bari de stil
        private void panelSpeed_Paint(object sender, PaintEventArgs e)
        {
            Brush gradBrush = new LinearGradientBrush(new Point(0, 0), new Point(panelSpeed.Width, 0), Color.Yellow, Color.Green);
            e.Graphics.DrawLine(new Pen(gradBrush, 10), new Point(10, 11), new Point(panelSpeed.Width - 10, 11));
            
            if (speedDraw != -1)
            {
                e.Graphics.DrawLine(new Pen(Color.White, 3), new Point(Math.Max((int)(speedDraw * 4.6), 10), 0), new Point(Math.Max((int)(speedDraw * 4.6), 10), panelSpeed.Height));
            }
        }

        private void panelStrength_Paint(object sender, PaintEventArgs e)
        {
            Brush gradBrush = new LinearGradientBrush(new Point(0, 0), new Point(panelStrength.Width, 0), Color.Blue, Color.Red);
            e.Graphics.DrawLine(new Pen(gradBrush, 10), new Point(10, 11), new Point(panelStrength.Width - 10, 11));
            if (strengthDraw != -1)
            {
                e.Graphics.DrawLine(new Pen(Color.White, 3), new Point(Math.Max((int)(strengthDraw * 4.6), 10), 0), new Point(Math.Max((int)(strengthDraw * 4.6), 10), panelStrength.Height));
            }
        }
        #endregion

        #region 4. Butoane de comanda
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            cycleCNT--;
            if (cycleCNT < 0)
                cycleCNT = styles.Count - 1;
            InitializeState();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            cycleCNT++;
            if (cycleCNT == styles.Count)
                cycleCNT = 0;
            InitializeState();
        }
        private void buttonDesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(styles[cycleCNT].descriere, "Descriere", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region 5. Butoane de actiune
        private void buttonMod_Click(object sender, EventArgs e)
        {
            FormModStiluri fMS = new FormModStiluri();
            fMS.Constr = constr;
            fMS.stil = new style(styles[cycleCNT].cod_stil, styles[cycleCNT].nume, styles[cycleCNT].viteza, styles[cycleCNT].putere, styles[cycleCNT].rank, styles[cycleCNT].procent, styles[cycleCNT].descriere);
            fMS.ShowDialog();

            styles.Clear();
            GetInfoFromDB();
            InitializeState();
        }

        private void buttonSterg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti stilul curent?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool inUse = false;
                string message = "Stilul acesta este folosit de:\n";
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Nume FROM [Personaje] WHERE Cod_Stil = @id", conn);
                    cmd.Parameters.AddWithValue("id", styles[cycleCNT].cod_stil);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        message += (string)dr[0] + "\n";
                        inUse = true;
                    }
                    dr.Close();
                    cmd.Dispose();
                    message += "Sunteti sigur ca doriti sa stergeti acest stil?";
                    if (inUse)
                    {
                        if (MessageBox.Show(message, "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("UPDATE [Personaje] SET Cod_Stil = 0 WHERE Cod_Stil = @id", conn);
                            cmd.Parameters.AddWithValue("id", styles[cycleCNT].cod_stil);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Comanda anulata.");
                            return;
                        }
                    }
                    conn.Close();
                }

                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM [Stiluri] WHERE Cod_Stil = @id", conn);
                    cmd.Parameters.AddWithValue("id", styles[cycleCNT].cod_stil);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }

                MessageBox.Show("Stergere reusita.", "DELETE CHECK: DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cycleCNT = 0;
                styles.Clear();
                GetInfoFromDB();
                if (!flagClose)
                    InitializeState();
                else
                {
                    MessageBox.Show("Toate stilurile au fost sterse, formularul va fi inchis.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddStiluri fAS = new FormAddStiluri();
            fAS.Constr = constr;
            fAS.ShowDialog();

            styles.Clear();
            GetInfoFromDB();
            InitializeState();
        }
        #endregion
    }
}
