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
    public partial class FormAddPersonaje : Form
    {
        #region 1. Variabilele declarate
        string photo = "";
        private static string constr;
        public string Constr { set { constr = value; } }
        #endregion
        public FormAddPersonaje()
        {
            InitializeComponent();
        }

        #region 2. Comenzile butoanelor
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxLocatie.Text == "" || textBoxNvl.Text == "" || textBoxBani.Text == "" || comboBoxFam.SelectedIndex == -1 || comboBoxStil.SelectedIndex == -1)
            {
                MessageBox.Show("Date invalide. Va rugam sa va verificati casetele de text.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Personaje](Nume, Locatie, Cod_Familie, Cod_Stil, Nivel, Bani) VALUES(@nm, @loc, @cf, @cs, @nvl, @bn)", conn);
                cmd.Parameters.AddWithValue("nm", textBoxName.Text); cmd.Parameters.AddWithValue("loc", textBoxLocatie.Text);
                cmd.Parameters.AddWithValue("cf", (int)comboBoxFam.SelectedValue); cmd.Parameters.AddWithValue("cs", (int)comboBoxStil.SelectedValue);
                cmd.Parameters.AddWithValue("nvl", Math.Min(Convert.ToInt32(textBoxNvl.Text), 20)); cmd.Parameters.AddWithValue("bn", (int)Math.Min(Convert.ToInt64(textBoxBani.Text), int.MaxValue));
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                if (photo == "")
                {
                    MessageBox.Show("Adaugare realizata cu succes!", "INSERT CHECK: DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.Close();
                }
                else
                {
                    int cID;
                    cmd = new SqlCommand("SELECT max(ID_Personaj) FROM [Personaje]", conn);
                    cID = (int)cmd.ExecuteScalar();
                    cmd.Dispose();

                    cmd = new SqlCommand("UPDATE [Personaje] SET Path_Poza = @ph WHERE ID_Personaj = @id", conn);
                    cmd.Parameters.AddWithValue("ph", (cID + ".png")); cmd.Parameters.AddWithValue("id", cID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    File.Copy(photo, Application.StartupPath + @"\PersPhotoResources\" + cID + @".png");
                    MessageBox.Show("Adaugare realizata cu succes!\nPoza referentiata cu succes!", "INSERT + COPY CHECK: DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.Close();
                }
            }
        }
        #endregion
        private void FormAddPersonaje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakuzaDataSet.Stiluri' table. You can move, or remove it, as needed.
            this.stiluriTableAdapter.Fill(this.yakuzaDataSet.Stiluri);
            // TODO: This line of code loads data into the 'yakuzaDataSet.Familii' table. You can move, or remove it, as needed.
            this.familiiTableAdapter.Fill(this.yakuzaDataSet.Familii);

            comboBoxFam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStil.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Icon = Properties.Resources.y0;
        }

        #region 3. Functii de control, pentru textbox-uri
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
