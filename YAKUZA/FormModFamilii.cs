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

namespace YAKUZA
{
    public partial class FormModFamilii : Form
    {
        #region 1. Variabilele declarate
        private static string constr;
        public string Constr { set { constr = value; } }
        public FormVizFamilii.family fm;
        #endregion
        public FormModFamilii()
        {
            InitializeComponent();
        }

        #region 2. Initializare date
        private void InitializeState()
        {
            textBoxNume.Text = fm.nume;
            textBoxLider.Text = fm.lider;
            numericUpDownMem.Value = fm.membri;
            comboBoxAfil.Text = fm.afiliere;
            comboBoxAfil.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion
        private void FormModFamilii_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'yakuzaDataSet.Familii' table. You can move, or remove it, as needed.
            this.familiiTableAdapter.Fill(this.yakuzaDataSet.Familii);
            InitializeState();
            this.Icon = Properties.Resources.y0;
        }

        #region 3. Butoane de comanda + verificare checkbox
        private void checkBoxTOP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTOP.Checked == true)
                comboBoxAfil.Enabled = false;
            else
                comboBoxAfil.Enabled = true;
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (textBoxNume.Text == "" || textBoxLider.Text == "" || ((comboBoxAfil.Text == "Neafiliat" || comboBoxAfil.Text == fm.nume) && checkBoxTOP.Checked == false))
            {
                MessageBox.Show("Date invalide. Va rugam sa verificati datele introduse!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBoxTOP.Checked == false)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    string curaff = comboBoxAfil.Text;
                    while (curaff != "TOP")
                    {
                        SqlCommand cmd = new SqlCommand("SELECT Afiliere FROM [Familii] WHERE Nume = @nm", conn);
                        cmd.Parameters.AddWithValue("nm", curaff);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            curaff = (string)dr[0];
                        }
                        dr.Close();
                        cmd.Dispose();
                        if (curaff == fm.nume)
                        {
                            MessageBox.Show("RECURENTA IERARHICA DETECTATA. Comanda anulata.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                            return;
                        }
                    }
                    conn.Close();
                }
            }

            if (MessageBox.Show("Doriti sa modificati familia selectata?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE [Familii] SET Afiliere = @nw WHERE Afiliere = @old", conn);
                    cmd.Parameters.AddWithValue("nw", textBoxNume.Text); cmd.Parameters.AddWithValue("old", fm.nume);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    cmd = new SqlCommand("UPDATE [Familii] SET Nume = @nm, Lider = @ld, Nr_Membri = @mem, Afiliere = @af WHERE Cod_Familie = @cf", conn);
                    cmd.Parameters.AddWithValue("cf", fm.cod_familie);
                    cmd.Parameters.AddWithValue("nm", textBoxNume.Text); cmd.Parameters.AddWithValue("ld", textBoxLider.Text);
                    cmd.Parameters.AddWithValue("mem", (int)numericUpDownMem.Value);

                    if (comboBoxAfil.Enabled == true)
                        cmd.Parameters.AddWithValue("af", comboBoxAfil.Text);
                    else
                        cmd.Parameters.AddWithValue("af", "TOP");

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }
                MessageBox.Show("Modificare realizata cu succes.", "PROMPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion
    }
}
