using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace elly_gym.forms
{
    public partial class saleres : Form
    {
        public saleres()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            home f = new home();
            f.Show();
            this.Hide();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            mortbat f = new mortbat();
            f.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bill f = new bill();
            f.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            total_costming n = new total_costming();
            n.Show();
            this.Hide();
        }

        private void saleres_Load(object sender, EventArgs e)
        {

        }
    }
}
