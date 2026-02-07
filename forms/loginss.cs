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
    public partial class loginss : Form
    {
        string type;
        PL.s_login log = new PL.s_login();
        public loginss()
        {
            InitializeComponent();
        }

        private void cb_OnChange(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                password.isPassword = false;
            }
            else
            {
                password.isPassword = true;

            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (admin.Checked == true)
            {
                type = "admin";
            }
            else if (user.Checked == true)
            {
                type = "user";


            }
            try
            {

                DataTable dt = log.slogin(user_name.Text, password.Text, type);
                if (dt.Rows.Count > 0)
                {
                    log.set_user(user_name.Text, type);
                    home f = new home();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("من فضلك اعد كتابه كلمه اسم المستخدم او كلمه المرور", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {
                MessageBox.Show("في مشكله في اللوجن", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("هل تريد الخروج من البرنامج؟؟", "warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
