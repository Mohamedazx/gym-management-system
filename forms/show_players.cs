using DevExpress.XtraReports.UI;
using elly_gym.report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace elly_gym.forms
{
    public partial class show_players : Form
    {
        PL.players_pl ob = new PL.players_pl();
        PL.s_login oc = new PL.s_login();
             DataTable dt = new DataTable();
        string delet_users ;
        public void player_Manegment_constractor()
        {

            dt = ob.vew_all_player();
            dgp.DataSource = dt;

            dgp.Columns[0].Width = 55;
            dgp.Columns[1].Width = 150;
            dgp.Columns[2].Width = 150;
            dgp.Columns[3].Width = 120;
            dgp.Columns[4].Width = 160;
            dgp.Columns[5].Width = 90;
            dgp.Columns[6].Width = 90;
            dgp.Columns[7].Width = 130;
            dgp.Columns[8].Width = 100;
            dgp.Columns[9].Width = 280;
           

          // dgp.Columns[8].DefaultCellStyle.Format = "d";

            dgp.Columns[8].DefaultCellStyle.Format = "c";
           

             //Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-US");
            dgp.AllowUserToAddRows = false;

        }
        public show_players()
        {
            InitializeComponent();
            player_Manegment_constractor();
        }

        private void show_players_Load(object sender, EventArgs e)
        {
            dt = oc.cutsh_type();
            typee.Text = dt.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           // this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                player_Manegment_constractor(); 
            }
            else
            {
                try
                {

                    dt = ob.search_player_info(Convert.ToString(search.Text));
                    this.dgp.DataSource = dt;


                }
                catch
                {
                    return;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dt = ob.search_player_date(Convert.ToDateTime(d1.Value), Convert.ToDateTime(d2.Value));
            this.dgp.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgp.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgp.Rows[i].Cells[8].Value);

            }
            costs.Text = "مجموع التكلفه:"+ x.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void costs_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            player_Manegment_constractor();

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            delet_users = typee.Text;
            if (delet_users == "user")
            {
                DialogResult DG = MessageBox.Show("غير مسموح لك بالحذف  ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    DialogResult DG = MessageBox.Show("هل انت متأكد من الحذف ؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DG == DialogResult.Yes)
                    {
                        if (dgp.CurrentRow == null)
                        {
                            MessageBox.Show("لايوجد شيْ لحذفه ");
                        }
                        else
                        {
                            try
                            {
                                ob.delete_blayer(Convert.ToInt32(dgp.CurrentRow.Cells[0].Value));
                                player_Manegment_constractor();
                            }
                            catch
                            {
                                return;
                            }
                        }
                    }
                    else if (DG == DialogResult.No)
                    {
                        return;
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            new_playr f = new new_playr();
            f.button1.Visible = false;
            f.button2.Visible = true;
            f.button2.Location = new Point(201, 604);
            f.id.Text = this.dgp.CurrentRow.Cells[0].Value.ToString();
            f.name.Text = this.dgp.CurrentRow.Cells[1].Value.ToString();
            f.serial.Text = this.dgp.CurrentRow.Cells[2].Value.ToString();
            f.mop.Text = this.dgp.CurrentRow.Cells[3].Value.ToString();
            f.adress.Text = this.dgp.CurrentRow.Cells[4].Value.ToString();
            f.come.Value = Convert.ToDateTime(this.dgp.CurrentRow.Cells[5].Value.ToString());
            f.go.Value = Convert.ToDateTime(this.dgp.CurrentRow.Cells[6].Value.ToString());
            f.total_day.Text = this.dgp.CurrentRow.Cells[7].Value.ToString();
            f.cost.Text = this.dgp.CurrentRow.Cells[8].Value.ToString();
            f.note.Text = this.dgp.CurrentRow.Cells[9].Value.ToString();
            if (this.dgp.CurrentRow.Cells[11].Value.ToString() == "unblock")
            {
                f.unblock.Checked = true;
            }
            else if (this.dgp.CurrentRow.Cells[11].Value.ToString() == "block")
            {
                f.unblock.Visible = false;
                f.block.Checked = true;

            }
            else
            {
                f.unblock.Checked = true;

            }
            f.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            player f = new player();
            f.ShowPreview();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
            home f = new home();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            new_playr f = new new_playr();
            f.Show();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            Double x = 0;
            for (int i = 0; i < dgp.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgp.Rows[i].Cells[8].Value);

            }
            costs.Text = "مجموع التكلفه:" + x.ToString();

        }
    }
}
