using DevExpress.XtraReports.UI;
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
    public partial class mortbat : Form
    {
        PL.mortbat ob = new PL.mortbat();
        DataTable dt = new DataTable();

        public void vew_salary_constractor()
        {

            dt = ob.vew_salary();
            dgp.DataSource = dt;

            dgp.Columns[0].Width = 60;
            dgp.Columns[1].Width = 150;
            dgp.Columns[2].Width = 150;
            dgp.Columns[3].Width = 120;
            dgp.Columns[4].Width = 120;
            dgp.Columns[5].Width = 120;
            dgp.Columns[6].Width = 120;
            dgp.Columns[7].Width = 200;
      
            dgp.Columns[3].DefaultCellStyle.Format = "c";
            dgp.Columns[4].DefaultCellStyle.Format = "c";
            dgp.Columns[5].DefaultCellStyle.Format = "c";
            dgp.Columns[6].DefaultCellStyle.Format = "c";

            dgp.AllowUserToAddRows = false;

        }


        public mortbat()
        {
            InitializeComponent();
            dt = ob.show_salary_id();
            id.Text = dt.Rows[0][0].ToString();
            vew_salary_constractor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "" && salary.Text == "")
                {
                    MessageBox.Show("برجاء ادخال البينات صحيحه", "اضافه مرتب جديد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    ob.new_salary(int.Parse(id.Text), name.Text, Convert.ToDateTime(date.Value.ToString()), Convert.ToDouble(salary.Text), Convert.ToDouble(add_salry.Text), Convert.ToDouble(minas.Text), Convert.ToDouble(total.Text), note.Text);
                    MessageBox.Show("تم الاضافه بنجاح", "اضافه مرتب جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = ob.show_salary_id();
                    id.Text = dt.Rows[0][0].ToString();
                    vew_salary_constractor();
                }
            }
            catch
            {
                MessageBox.Show("خطأ", "اضافه مرتب جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void mortbat_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dt = ob.search_salary_date(Convert.ToDateTime(d1.Value), Convert.ToDateTime(d2.Value));
            this.dgp.DataSource = dt;
            Double x = 0;
            for (int i = 0; i < dgp.Rows.Count; i++)
            {
                x += Convert.ToDouble(dgp.Rows[i].Cells[6].Value);

            }
            costs.Text = "costs:" + x.ToString();
        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

            if (salary.Text == "")
            {

                total.Text = salary.Text;
            }
            else
            {
                add_salry.Text = "0";
                minas.Text = "0";
                total.Text = Convert.ToString(Convert.ToInt32(salary.Text) + Convert.ToInt32(add_salry.Text) - Convert.ToInt32(minas.Text));
            }
        }
        int soso;
        int mido;
        private void add_salry_TextChanged(object sender, EventArgs e)
        {
            // total.Text = Convert.ToString(Convert.ToInt32(salary.Text)+Convert.ToInt32(add_salry));
            try
            {
                total.Text = Convert.ToString(Convert.ToInt32(salary.Text) + Convert.ToInt32(add_salry.Text));
            }
            catch
            {
                return;
            }


        }

        private void minas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                total.Text = Convert.ToString(Convert.ToInt32(salary.Text) + Convert.ToInt32(add_salry.Text) - Convert.ToInt32(minas.Text));
            }
            catch
            {
                return;
            }
            //  mido = Convert.ToInt32(salary.Text) - Convert.ToInt32(minas.Text);
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DG = MessageBox.Show("هل انت متأكد من الحذف ؟ ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DG == DialogResult.Yes)
                {
                    ob.delete_salary(Convert.ToInt32(this.dgp.CurrentRow.Cells[0].Value));
                    vew_salary_constractor();
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            vew_salary_constractor();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            report.mortbat h = new report.mortbat();
            h.ShowPreview();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "" && salary.Text == "")
                {
                    MessageBox.Show("برجاء ادخال البينات كامله", "تعديل مرتب جديد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    ob.abdate_salary(int.Parse(id.Text), name.Text, Convert.ToDateTime(date.Value.ToString()), Convert.ToDouble(salary.Text), Convert.ToDouble(add_salry.Text), Convert.ToDouble(minas.Text), Convert.ToDouble(total.Text), note.Text);
                    MessageBox.Show("تم التعديل بنجاح", "تعديل مرتب ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = ob.show_salary_id();
                    id.Text = dt.Rows[0][0].ToString();
                    name.Text = "";
                    date.Value = DateTime.Now;
                    salary.Text = "";
                    add_salry.Text = "";
                    minas.Text = "";
                    total.Text = "";
                    note.Text = "";
                    vew_salary_constractor();
                }
            }
            catch
            {
                MessageBox.Show("خطأ", "تعديل مرتب ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt = ob.show_salary_id();
                id.Text = dt.Rows[0][0].ToString();
                vew_salary_constractor();
                name.Text = "";
                date.Value = DateTime.Now;
                salary.Text = "";
                add_salry.Text = "";
                minas.Text = "";
                total.Text = "";
                note.Text = "";

            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            id.Text = this.dgp.CurrentRow.Cells[0].Value.ToString();
            name.Text = this.dgp.CurrentRow.Cells[1].Value.ToString();
            date.Value = Convert.ToDateTime(this.dgp.CurrentRow.Cells[2].Value.ToString());
            salary.Text = this.dgp.CurrentRow.Cells[3].Value.ToString();
            add_salry.Text = this.dgp.CurrentRow.Cells[4].Value.ToString();
            minas.Text = this.dgp.CurrentRow.Cells[5].Value.ToString();
            total.Text = this.dgp.CurrentRow.Cells[6].Value.ToString();
            note.Text = this.dgp.CurrentRow.Cells[7].Value.ToString();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            saleres f = new saleres();
            f.Show();
            this.Hide();
        }
    }
}
