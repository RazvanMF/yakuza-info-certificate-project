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
    public partial class FormAddStiluri : Form
    {
        #region 1. Variabilele declarate
        private static string constr;
        public string Constr { set { constr = value; } }
        #endregion
        public FormAddStiluri()
        {
            InitializeComponent();
        }

        #region 2. Butoane de comanda
        private void buttonMinRk_Click(object sender, EventArgs e)
        {
            int nr = Convert.ToInt32(labelRank.Text);
            nr--;
            if (nr <= 0)
                nr = 5;
            labelRank.Text = nr.ToString();
        }

        private void buttonPlsRk_Click(object sender, EventArgs e)
        {
            int nr = Convert.ToInt32(labelRank.Text);
            nr++;
            if (nr >= 6)
                nr = 1;
            labelRank.Text = nr.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxDescriere.Text == "")
                textBoxDescriere.Text = "null";
            if (textBoxNume.Text == "")
            {
                MessageBox.Show("Numele stilului nu a fost introdus!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Stiluri](Nume, Viteza, Putere, Rank, Procent, Descriere) VALUES(@nm, @vt, @pt, @rk, @proc, @desc)", conn);
                cmd.Parameters.AddWithValue("nm", textBoxNume.Text); cmd.Parameters.AddWithValue("desc", textBoxDescriere.Text);
                cmd.Parameters.AddWithValue("vt", numericUpDownVit.Value); cmd.Parameters.AddWithValue("pt", numericUpDownPut.Value); cmd.Parameters.AddWithValue("proc", numericUpDownProc.Value);
                cmd.Parameters.AddWithValue("rk", Convert.ToInt32(labelRank.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            MessageBox.Show("Adaugare realizata cu succes!", "INSERT CHECK: DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion

        private void FormAddStiluri_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.y0;
        }
    }
}
