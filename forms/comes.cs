using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace elly_gym.forms
{
    public partial class comes : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RH94TE5;Initial Catalog=elly_gym;Integrated Security=True");

        PL.players_pl ob = new PL.players_pl();
        DataTable dt = new DataTable();
        public void player_Manegment_constractor()
        {

            dt = ob.vew_com_player();
            dgp.DataSource = dt;

            dgp.Columns[0].Width = 55;
            dgp.Columns[1].Width = 200;
            dgp.Columns[2].Width = 200;
            dgp.Columns[3].Width = 200;
            dgp.Columns[4].Width = 200;
            dgp.Columns[5].Width = 200;
            dgp.Columns[6].Width = 250;
           

          // dgp.Columns[8].DefaultCellStyle.Format = "c";
  
            dgp.AllowUserToAddRows = false;

        }
        public comes()
        {
            InitializeComponent();
            player_Manegment_constractor();
            date_now.Text = DateTime.Now.ToShortDateString();
            typeee.Text = DateTime.Now.ToShortTimeString();
        }

        private void comes_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                player_Manegment_constractor();
            }
            else
            {
                try
                {
                    dt = ob.search_comes_info(Convert.ToString(id.Text));
                    this.dgp.DataSource = dt;
                }
                catch
                {
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int id1 = Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value);
            // int id2 = Convert.ToInt32(search.Text);
           
           
            

        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button2.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("id لا يوجد", "come players", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                if (this.dgp.CurrentRow == null)
                {
                    MessageBox.Show("غير موجود", "come players", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    try
                    {
                        DateTime d1 = DateTime.Now.Date;
                        DateTime d3 = Convert.ToDateTime(this.dgp.CurrentRow.Cells[3].Value);

                        if (d1 <= d3)
                        {
                            if (this.dgp.CurrentRow.Cells[6].Value.ToString() == "block")
                            {
                                MessageBox.Show("هذا المستخدم ممنوع من الدخول", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                id.Text = "";
                                id.Focus();

                            }
                            else
                            {
                                DateTime d4 = Convert.ToDateTime(this.dgp.CurrentRow.Cells[5].Value);

                                if (d4 == d1)
                                {
                                    DateTime d = new DateTime();
                                    dt =ob.show_time(Convert.ToInt32(id.Text));
                                    typee.Text =Convert.ToDateTime(  dt.Rows[0][0].ToString()).ToShortDateString();

                                    typeee.Text = Convert.ToDateTime(dt.Rows[0][0].ToString()).ToShortTimeString();

                                    MessageBox.Show(typeee.Text+ " لقد تم الحضور في هذا اليوم عند ", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    id.Text = "";
                                    player_Manegment_constractor();
                                }
                                else
                                {
                                    ob.update_player_come(int.Parse(id.Text), Convert.ToDateTime(date_now.Text),typeee.Text);
                                    MessageBox.Show("تم التسجيل بنجاح ...", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    player_Manegment_constractor();
                                    id.Text = "";

                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("هذا المشترك نفذت مده عضويته...", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            DialogResult DG = MessageBox.Show("هل تريد حذف هذا اللاعب؟؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (DG == DialogResult.Yes)
                            {


                                string sql = "delete new_player where id='" + id.Text + "';";
                                con.Open();
                                SqlCommand cmd = new SqlCommand(sql, con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("تم الحذف");
                                con.Close();
                                id.Text = "";
                                player_Manegment_constractor();

                            }
                            else if (DG == DialogResult.No)
                            {
                                return;
                            }

                            player_Manegment_constractor();

                        }


                    }
                    catch
                    {
                        MessageBox.Show("خطأ", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}

