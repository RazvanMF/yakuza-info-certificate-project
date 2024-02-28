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
    public partial class FormVizFamilii : Form
    {
        #region 1. Variabilele declarate
        private int indx = 0;
        private static string constr;
        public string Constr { set { constr = value; } }

        public struct family
        {
            public int cod_familie, index;
            public string nume, lider, afiliere;
            public int membri;

            public family(int cf, string nm, string ld, int mem, string af, int ind)
            {
                cod_familie = cf; index = ind;
                nume = nm; lider = ld; afiliere = af;
                membri = mem;
            }
        }
        private List<family> families = new List<family>();
        bool flagClose = false;
        #endregion
        public FormVizFamilii()
        {
            InitializeComponent();
        }
        #region 2. Obtinere informatii din baza de date + Initializare + Generare arbore
        private void GetInfoFromDB()
        {
            flagClose = false;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                indx = 0;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Familii] WHERE Cod_Familie > 0", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    families.Add(new family((int)dr[0], (string)dr[1], (string)dr[2], (int)dr[3], (string)dr[4], indx++));
                }
                cmd.Dispose();
                dr.Dispose();
                conn.Close();
            }
            if (families.Count == 0)
                flagClose = true;
        }

        private void GenerateTree(ref TreeNode root)
        {
            if (root == null)
            {
                root = new TreeNode();
                root.Text = "Familii/Asociatii";
                root.Tag = null;

                var asocs = families.Where(p => p.afiliere == "TOP");
                foreach (var asoc in asocs)
                {
                    TreeNode child = new TreeNode();
                    child.Text = asoc.nume;
                    child.Tag = asoc.index;

                    GenerateTree(ref child);
                    root.Nodes.Add(child);
                }
            }
            else
            {
                string name = root.Text;
                var asocs = families.Where(p => p.afiliere == name);
                foreach (var asoc in asocs)
                {
                    TreeNode child = new TreeNode();
                    child.Text = asoc.nume;
                    child.Tag = asoc.index;

                    GenerateTree(ref child);
                    root.Nodes.Add(child);
                }
            }
        }

        private void treeViewFamily_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewFamily.SelectedNode.Tag != null)
            {
                family fam = families[(int)treeViewFamily.SelectedNode.Tag];
                labelNume.Text = fam.nume; labelMembri.Text = fam.membri.ToString();
                labelLider.Text = fam.lider; labelAfiliere.Text = (fam.afiliere == "TOP" ? "-" : fam.afiliere);
                buttonDel.Enabled = true; buttonMod.Enabled = true;
            }
            else
            {
                labelNume.Text = "-"; labelLider.Text = "-";
                labelMembri.Text = "-"; labelAfiliere.Text = "-";
                buttonDel.Enabled = false; buttonMod.Enabled = false;
            }
        }
        #endregion

        private void FormVizFamilii_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.y0;
        redo:
            TreeNode root = null;
            GetInfoFromDB();
            if (!flagClose)
            {
                GenerateTree(ref root);
                treeViewFamily.Nodes.Add(root);
                treeViewFamily.ExpandAll();
            }
            else
            {
                if (MessageBox.Show("Baza de date nu contine nici o familie. Doriti sa creati una?", "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FormAddFamilii fAF = new FormAddFamilii();
                    fAF.Constr = constr;
                    fAF.ShowDialog();
                    goto redo;
                }
                else
                    this.Close();
            }
        }

        #region 3. Butoane de comanda
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti familia selectata?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes 
                && treeViewFamily.SelectedNode.Tag != null)
            {
                string message = "Din aceasta familie fac parte:\n";
                bool inUse = false;

                string fatherClan = "TOP";
                if (families[(int)treeViewFamily.SelectedNode.Tag].afiliere == "TOP")
                    fatherClan = "TOP";

                else
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT Afiliere FROM [Familii] WHERE Nume = @af", conn);
                        cmd.Parameters.AddWithValue("af", treeViewFamily.SelectedNode.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            fatherClan = (string)dr[0];
                        }
                        dr.Close();
                        cmd.Dispose();
                        conn.Close();
                    }
                }

                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Nume FROM [Personaje] WHERE Cod_Familie = @cf", conn);
                    cmd.Parameters.AddWithValue("cf", families[(int)treeViewFamily.SelectedNode.Tag].cod_familie);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        message += (string)dr[0] + "\n";
                        inUse = true;
                    }
                    dr.Close();
                    cmd.Dispose();
                    if (inUse)
                    {
                        message += "Familia va fi dereferentiata. Ierarhia familiala va fi modificata. Doriti sa continuati?";
                        if (MessageBox.Show(message, "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("UPDATE [Personaje] SET Cod_Familie = 0 WHERE Cod_Familie = @cf", conn);
                            cmd.Parameters.AddWithValue("cf", families[(int)treeViewFamily.SelectedNode.Tag].cod_familie);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();

                            cmd = new SqlCommand("UPDATE [Familii] SET Afiliere = @nw WHERE Afiliere = @old", conn);
                            cmd.Parameters.AddWithValue("nw", fatherClan);
                            cmd.Parameters.AddWithValue("old", treeViewFamily.SelectedNode.Text);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        else
                            MessageBox.Show("Comanda anulata.");
                    }
                    else
                    {
                        message = "Ierarhia familiala va fi modificata. Doriti sa continuati?";
                        if (MessageBox.Show(message, "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("UPDATE [Familii] SET Afiliere = @nw WHERE Afiliere = @old", conn);
                            cmd.Parameters.AddWithValue("nw", fatherClan);
                            cmd.Parameters.AddWithValue("old", treeViewFamily.SelectedNode.Text);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        else
                            MessageBox.Show("Comanda anulata.");
                    }
                }

                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM [Familii] WHERE Cod_Familie = @cf", conn);
                    cmd.Parameters.AddWithValue("cf", families[(int)treeViewFamily.SelectedNode.Tag].cod_familie);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    conn.Close();
                }
                MessageBox.Show("Stergere realizata cu succes!");

                TreeNode tn = null;
                treeViewFamily.Nodes.Clear();
                families.Clear();
                GetInfoFromDB();
                if (!flagClose)
                {
                    GenerateTree(ref tn);
                    treeViewFamily.Nodes.Add(tn);
                    treeViewFamily.ExpandAll();
                    labelNume.Text = "-"; labelLider.Text = "-";
                    labelMembri.Text = "-"; labelAfiliere.Text = "-";
                    treeViewFamily.SelectedNode = treeViewFamily.Nodes[0];
                }
                else
                {
                    MessageBox.Show("Toate familiile au fost sterse. Formularul va fi inchis.", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddFamilii fAF = new FormAddFamilii();
            fAF.Constr = constr;
            fAF.ShowDialog();

            TreeNode tn = null;
            treeViewFamily.Nodes.Clear();
            families.Clear();
            GetInfoFromDB();
            GenerateTree(ref tn);
            treeViewFamily.Nodes.Add(tn);
            treeViewFamily.ExpandAll();
            treeViewFamily.SelectedNode = treeViewFamily.Nodes[0];
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            FormModFamilii fMF = new FormModFamilii();
            fMF.Constr = constr;
            fMF.fm = new family(families[(int)treeViewFamily.SelectedNode.Tag].cod_familie, families[(int)treeViewFamily.SelectedNode.Tag].nume, families[(int)treeViewFamily.SelectedNode.Tag].lider, families[(int)treeViewFamily.SelectedNode.Tag].membri, families[(int)treeViewFamily.SelectedNode.Tag].afiliere, (int)treeViewFamily.SelectedNode.Tag);
            fMF.ShowDialog();

            TreeNode tn = null;
            treeViewFamily.Nodes.Clear();
            families.Clear();
            GetInfoFromDB();
            GenerateTree(ref tn);
            treeViewFamily.Nodes.Add(tn);
            treeViewFamily.ExpandAll();
            treeViewFamily.SelectedNode = treeViewFamily.Nodes[0];
        }
        #endregion
    }
}
