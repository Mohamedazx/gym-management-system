
using DevExpress.XtraReports.UI;
using elly_gym.report;
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
    public partial class bill : Form
    {
        PL.bills ob = new PL.bills();
        DataTable dt = new DataTable();

        public void vew_bill_constractor()
        {

            dt = ob.vew_bill();
            dgp.DataSource = dt;

            dgp.Columns[0].Width = 70;
            dgp.Columns[1].Width = 150;
            dgp.Columns[2].Width = 150;
            dgp.Columns[3].Width = 200;
           

            dgp.Columns[1].DefaultCellStyle.Format = "c";
        
            dgp.AllowUserToAddRows = false;

        }
        public bill()
        {
            InitializeComponent();
            vew_bill_constractor();
            dt = ob.show_bill_id();
            id.Text = dt.Rows[0][0].ToString();
        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dt = ob.search_bill_date(Convert.ToDateTime(d1.Value),Convert.ToDateTime(d2.Value));
            this.dgp.DataSource = dt;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ob.new_bill(int.Parse(id.Text), (float)Convert.ToDouble(amount.Text), Convert.ToDateTime(date.Value.ToString()), note.Text);
            dt = ob.show_bill_id();
            id.Text = dt.Rows[0][0].ToString();
            vew_bill_constractor();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            saleres f = new saleres();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DG = MessageBox.Show("هل انت متأكد من الحذف ؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DG == DialogResult.Yes)
                {
                    ob.delete_bill(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value));
                    vew_bill_constractor();
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

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            vew_bill_constractor();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            /*bills f = new bills();
            f.ShowPreview();*/
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            dt = ob.search_bill_date(Convert.ToDateTime(d1.Value), Convert.ToDateTime(d2.Value));
            this.dgp.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgp.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgp.Rows[i].Cells[1].Value);

            }
            costs.Text = "costs:" + x.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
