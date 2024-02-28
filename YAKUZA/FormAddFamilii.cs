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
    public partial class FormAddFamilii : Form
    {
        #region 1. Variabilele declarate
        private static string constr;
        public string Constr { set { constr = value; } }
        #endregion
        public FormAddFamilii()
        {
            InitializeComponent();
        }

        private void FormAddFamilii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakuzaDataSet.Familii' table. You can move, or remove it, as needed.
            this.familiiTableAdapter.Fill(this.yakuzaDataSet.Familii);
            comboBoxAfil.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Icon = Properties.Resources.y0;

        }

        #region 2. Butoane de comanda + verificari checkbox
        private void checkBoxTOP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTOP.Checked)
                comboBoxAfil.Enabled = false;
            else
                comboBoxAfil.Enabled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNume.Text == "" || textBoxLider.Text == "" || (comboBoxAfil.Text == "Neafiliat" && checkBoxTOP.Checked == false))
            {
                MessageBox.Show("Date invalide. Va rugam sa verificati datele introduse!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Familii](Nume, Lider, Nr_Membri, Afiliere) VALUES(@nm, @ld, @mem, @af)", conn);
                cmd.Parameters.AddWithValue("nm", textBoxNume.Text);
                cmd.Parameters.AddWithValue("ld", textBoxLider.Text);
                cmd.Parameters.AddWithValue("mem", numericUpDownMem.Value);
                if (checkBoxTOP.Checked)
                    cmd.Parameters.AddWithValue("af", "TOP");
                else
                    cmd.Parameters.AddWithValue("af", comboBoxAfil.Text);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
            }
            MessageBox.Show("Adaugare realizata cu succes!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion
    }
}
