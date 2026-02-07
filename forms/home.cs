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
    public partial class home : Form
    {
        DataTable dt = new DataTable();
        PL.s_login ob = new PL.s_login();
        string delet_users;
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            buckup f = new buckup();
            f.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new_playr f = new new_playr();
            f.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            show_players f = new show_players();
            f.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            delet_users = typee.Text;
            if (delet_users == "user")
            {
                DialogResult DG = MessageBox.Show("غير مسموح لك بالدخول  ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                saleres f = new saleres();
                f.Show();
                this.Hide();
            }
                /*pass f = new pass();
                f.ShowDialog();
                this.Close();*/
            }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            comes f = new comes();
            f.Show();
            this.Hide();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("هل تريد الخروج من البرنامج ؟", "warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            loginss f = new loginss();
            f.Show();
            this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {
            dt = ob.cutsh_type();
            typee.Text = dt.Rows[0][0].ToString();
        }
    }
}
