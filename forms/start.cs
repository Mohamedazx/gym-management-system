using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elly_gym.forms
{
    public partial class start : Form
    {
        int startpoint = 0;
        public start()
        {
            InitializeComponent();
            this.timer1.Start();
           // Opacity = 50;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void start_Load(object sender, EventArgs e)
        {
            //this.Opacity = 0;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpoint += 2;
            bunifuCircleProgressbar1.Value = startpoint;
            bunifuProgressBar1.Value = startpoint;
           // start.Opacity = startpoint;
            if (bunifuCircleProgressbar1.Value == 100)
            {
               // bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                loginss n = new loginss();
                n.Show();
                this.Hide();

            }

        }
    }
}
