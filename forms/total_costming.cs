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
    public partial class total_costming : Form
    {
        DataTable dt = new DataTable();
        PL.mortbat ob = new PL.mortbat();

        public void vew_salary_constractor()
        {
            dt = ob.all_trancfare();
            dgp.DataSource = dt;
            dgp.Columns[0].Width = 175;
            dgp.Columns[0].DefaultCellStyle.Format = "c";
            dgp.AllowUserToAddRows = false;
        }
        public void vew_bill_constractor()
        {
            dt = ob.allbills();
            dgv.DataSource = dt;
            dgv.Columns[0].Width = 175;
            dgv.Columns[0].DefaultCellStyle.Format = "c";
            dgv.AllowUserToAddRows = false;
        }
        public void vew_cash_constractor()
        {
            dt = ob.allsalary();
            dgc.DataSource = dt;
            dgc.Columns[0].Width = 175;
            dgc.Columns[0].DefaultCellStyle.Format = "c";
            dgc.AllowUserToAddRows = false;
        }
        public total_costming()
        {
            InitializeComponent();
            cost.Text = " : الربح";

            vew_salary_constractor();
            vew_cash_constractor();
            vew_bill_constractor();
        }

        private void total_costming_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
             dt = ob.search_for_cost_players(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
           this.dgp.DataSource = dt;
           Double x = 0;
           for (int i = 0; i < dgp.Rows.Count; i++)
           {
               x += Convert.ToDouble(dgp.Rows[i].Cells[0].Value);

           }
           cost.Text = "دخل الاشتركات : " + x.ToString();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dt = ob.all_bills_s(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgv.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgv.Rows[i].Cells[0].Value);

            }
            cost.Text = "مجموع الفواتير : " + x.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            dt = ob.all_salary_s(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgc.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgc.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgc.Rows[i].Cells[0].Value);

            }
            cost.Text = "مجموع المرتبات : " + x.ToString();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            dt = ob.search_for_cost_players(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgp.DataSource = dt;
            dt = ob.all_bills_s(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgv.DataSource = dt;
            dt = ob.all_salary_s(Convert.ToDateTime(start.Value), Convert.ToDateTime(end.Value));
            this.dgc.DataSource = dt;

            
            Double x = 0;
            Double y = 0;
            Double z = 0;
            for (int i = 0; i < dgp.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgp.Rows[i].Cells[0].Value);

            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                y += Convert.ToDouble(dgv.Rows[i].Cells[0].Value);

            }
            for (int i = 0; i < dgc.Rows.Count; i++)
            {
                z += Convert.ToDouble(dgc.Rows[i].Cells[0].Value);

            }


            cost.Text = "الربح : " + (x-(y+z)).ToString();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            home n = new home();
            n.Show();
            this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
              vew_salary_constractor();
              vew_cash_constractor();
              vew_bill_constractor();
            cost.Text = "الربح :";
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            saleres n = new saleres();
            n.Show();
            this.Hide();
        }
    }
}
