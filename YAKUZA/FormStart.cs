using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace YAKUZA
{
    public partial class FormStart : Form
    {
        #region 1. Variabile de functionalitate (soundplayer-ul, connection string-ul!!)
        SoundPlayer sp = new SoundPlayer(Application.StartupPath + @"\MusicResources\Yakuza0-EnglishOpening.wav");
        //private static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\yakuza.mdf;Integrated Security = True; Connect Timeout = 30";
        private static string constr = @"Data Source=DESKTOP-MAIN; Database=yakuza; User Instance = false; Integrated Security = False; TrustServerCertificate=True; MultipleActiveResultSets=True; Trusted_Connection=True; Connect Timeout = 10";
        #endregion
        public FormStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormStartLoading fSL = new FormStartLoading();
            this.Hide();
            fSL.ShowDialog();
            this.Show();
            buttonPlay.PerformClick();
            this.Icon = Properties.Resources.y0;
        }

        #region 2. Butoanele de comanda (start / stop muzica, iesire)
        private void allButtonComms_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            switch(bt.Text[0])
            {
                case 'E':
                    this.Close();
                    break;
                case 'P':
                    sp.Play();
                    break;
                case 'S':
                    sp.Stop();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 3. Butoanele de functionalitate (personaj, stil, familie, jukebox, admin)
        private void buttonJuke_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = (Application.StartupPath + @"\..\..\..\YakuzaJukeBox\YakuzaJukeBox\bin\Debug\YakuzaJukeBox.exe");
            proc.Start();
            sp.Stop();
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            sp.Stop();
            FormStartAdmin fSAdmin = new FormStartAdmin();
            fSAdmin.Constr = constr;
            fSAdmin.ShowDialog();
            GC.Collect();
            sp.Play();
        }

        private void buttonChar_Click(object sender, EventArgs e)
        {
            sp.Stop();
            FormVizPersonaje fVP = new FormVizPersonaje();
            fVP.Constr = constr;
            fVP.ShowDialog();
            GC.Collect();
            sp.Play();
        }

        private void buttonStyle_Click(object sender, EventArgs e)
        {
            sp.Stop();
            FormVizStiluri fVS = new FormVizStiluri();
            fVS.Constr = constr;
            fVS.ShowDialog();
            GC.Collect();
            sp.Play();

        }

        private void buttonFamilies_Click(object sender, EventArgs e)
        {
            sp.Stop();
            FormVizFamilii fVF = new FormVizFamilii();
            fVF.Constr = constr;
            fVF.ShowDialog();
            GC.Collect();
            sp.Play();
        }
        #endregion
    }
}
