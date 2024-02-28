using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YakuzaJukebox
{
    public partial class FormJukebox : Form
    {
        WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
        public FormJukebox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wmp.settings.volume = 33;
            wmp.URL = Application.StartupPath + @"\MusicResources\" + comboBoxMusic.Text + ".mp3";
            wmp.controls.play();
            timerSong.Start();
            this.Icon = Properties.Resources.y0;
            comboBoxMusic.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            timerSong.Stop();
            progressBarLength.Value = 0;
            timerSong.Start();

            wmp.controls.stop();
            wmp.URL = Application.StartupPath + @"\MusicResources\" + comboBoxMusic.Text + ".mp3";
            wmp.controls.play();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
            timerSong.Stop();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            wmp.controls.play();
            timerSong.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
            timerSong.Stop();
            progressBarLength.Value = 0;
            label1.Text = "00:00";
            label2.Text = "00:00";
        }

        private void timerSong_Tick(object sender, EventArgs e)
        {
            double percent = 0;
            if (wmp.controls.currentItem.duration != 0)
                percent = wmp.controls.currentPosition / wmp.controls.currentItem.duration;
            progressBarLength.Value = (int)(percent * progressBarLength.Maximum);
            label1.Text = wmp.controls.currentPositionString;
            label2.Text = wmp.controls.currentItem.durationString;
        }
    }
}
