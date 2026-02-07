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
    public partial class new_playr : Form
    {
        elly_gym.PL.players_pl ob = new PL.players_pl();
        elly_gym.PL.s_login obb = new PL.s_login();
        DataTable dt = new DataTable();
        string type;
        string bock;
        string delet_users;
        PL.s_login log = new PL.s_login();
        public new_playr()
        {
            InitializeComponent();
            go.Enabled=false;
            dt = ob.show_user_id();
            id.Text = dt.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text != "" && cost.Text != "")
                {
                        
                    ob.new_player(int.Parse(id.Text), name.Text, serial.Text, mop.Text
                        , adress.Text, Convert.ToDateTime(come.Value.ToShortDateString()),
                        Convert.ToDateTime(go.Value.ToShortDateString())
                        , total_day.SelectedItem.ToString(),Convert.ToDouble(cost.Text),
                        note.Text,Convert.ToDateTime( date_come.Value.ToShortTimeString()), bock);
                    MessageBox.Show("تم الاضافه بنجاح ...", "Adding New Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = ob.show_user_id();
                    id.Text = dt.Rows[0][0].ToString();
                    name.Text = "";
                    serial.Text = "";
                    mop.Text = "";
                    adress.Text = "";
                    come.Value = DateTime.Now;
                    go.Value = DateTime.Now;
                    total_day.Text = "";
                    cost.Text = "";
                    note.Text = "";
                    date_come.Value = DateTime.Now;
               }
                else
                {
                    MessageBox.Show("ادخل البينات كامله !! ...", "Adding New Player", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("خطا في اضافه لاعب جديد!"+e.ToString(), "Adding New Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text != "" && cost.Text != "")
                {
                    ob.update_player(int.Parse(id.Text), name.Text, serial.Text, mop.Text
                        , adress.Text, Convert.ToDateTime(come.Value.ToShortDateString()), Convert.ToDateTime(go.Value.ToShortDateString())
                        , total_day.SelectedItem.ToString(), Convert.ToDouble(cost.Text), note.Text, bock);
                    MessageBox.Show("تم التعديل بنجاح ...", "update players", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = ob.show_user_id();
                    id.Text = dt.Rows[0][0].ToString();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("ادخل البينات كامله !! ...", "update players", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("حدث خطأ عند التعديل !"+e.ToString(), "update players", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void go_ValueChanged(object sender, EventArgs e)
        {

        }

        private void block_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button_block_Click(object sender, EventArgs e)
        {
          
           
             
        }

        private void unblock_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void block_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {



                delet_users = typee.Text;
                if (delet_users == "user")
                {
                    DialogResult DG = MessageBox.Show("غير مسموح لك... ", "حظر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bock = "unblock";
                    unblock.Focus();
                }
                else
                {
                    MessageBox.Show(" تم منع هذا المستخدم من الدخول ", "Blocking", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bock = "block";
                    unblock.Visible = true;
                }

            }

            catch
            {
                 MessageBox.Show("في مشكله في تحديد العضويه !"+e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           


        }

        private void unblock_CheckedChanged_1(object sender, EventArgs e)
        {
            bock = "unblock";

        }

        private void new_playr_Load(object sender, EventArgs e)
        {
            dt = obb.cutsh_type();
            typee.Text = dt.Rows[0][0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (total_day.SelectedItem.ToString() == "نص شهر") 
            {
                go.Value = come.Value.AddDays(15);
            }
            else if(total_day.SelectedItem.ToString() == "شهر")
            {
                go.Value = come.Value.AddMonths(1);
            }
            else if (total_day.SelectedItem.ToString() == "شهرين")
            {
                go.Value = come.Value.AddMonths(2);
            }
            else if (total_day.SelectedItem.ToString() == "ثلاثه اشهر")
            {
                go.Value = come.Value.AddMonths(3);
            }
            else if (total_day.SelectedItem.ToString() == "سنه")
            {
                go.Value = come.Value.AddYears(1);
            }
            else
            {
                MessageBox.Show("خطأ");
            }
        }
    }
}
