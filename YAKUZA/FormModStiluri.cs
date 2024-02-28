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
    public partial class FormModStiluri : Form
    {
        #region 1. Variabilele declarate
        private static string constr;
        public string Constr { set { constr = value; } }
        public FormVizStiluri.style stil;
        #endregion
        public FormModStiluri()
        {
            InitializeComponent();
        }

        #region 2. Initializarea datelor primite din formularul mama
        private void InitializeState()
        {
            textBoxDescriere.Text = stil.descriere;
            textBoxNume.Text = stil.nume; textBoxID.Text = stil.cod_stil.ToString();
            numericUpDownVit.Value = stil.viteza; numericUpDownProc.Value = stil.procent; numericUpDownPut.Value = stil.putere;
            labelRank.Text = stil.rank.ToString();
        }
        #endregion

        private void FormModStiluri_Load(object sender, EventArgs e)
        {
            InitializeState();
            this.Icon = Properties.Resources.y0;
        }

        #region 3. Butoane de comanda

        private void buttonMinRk_Click(object sender, EventArgs e)
        {
            stil.rank--;
            if (stil.rank <= 0)
                stil.rank = 5;
            labelRank.Text = stil.rank.ToString();
        }

        private void buttonPlsRk_Click(object sender, EventArgs e)
        {
            stil.rank++;
            if (stil.rank >= 6)
                stil.rank = 1;
            labelRank.Text = stil.rank.ToString();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (textBoxDescriere.Text == "")
                textBoxDescriere.Text = "null";
            if (textBoxNume.Text == "")
            {
                MessageBox.Show("Numele stilului nu a fost introdus!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Sunteti sigur ca doriti sa modificati datele stilului?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE [Stiluri] SET Nume = @nm, Viteza = @vt, Putere = @pt, Rank = @rk, Procent = @pr, Descriere = @desc WHERE Cod_Stil = @id", conn);
                    cmd.Parameters.AddWithValue("id", textBoxID.Text.ToString());
                    cmd.Parameters.AddWithValue("nm", textBoxNume.Text); cmd.Parameters.AddWithValue("desc", textBoxDescriere.Text);
                    cmd.Parameters.AddWithValue("vt", numericUpDownVit.Value); cmd.Parameters.AddWithValue("pt", numericUpDownPut.Value); cmd.Parameters.AddWithValue("pr", numericUpDownProc.Value);
                    cmd.Parameters.AddWithValue("rk", Convert.ToInt32(labelRank.Text));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }
                MessageBox.Show("Modificare realizata cu succes!", "INSERT CHECK: DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion
    }
}
