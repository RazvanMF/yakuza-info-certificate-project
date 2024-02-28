using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAKUZA
{
    public partial class FormStartLoading : Form
    {
        int timeElapsed = 5;
        public FormStartLoading()
        {
            InitializeComponent();
        }

        private void FormStartLoading_Load(object sender, EventArgs e)
        {
            timerClose.Start();
            this.Icon = Properties.Resources.y0;
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timeElapsed--;
            label5.Text = timeElapsed.ToString();
            if (timeElapsed == 0)
                this.Close();
        }
    }
}
