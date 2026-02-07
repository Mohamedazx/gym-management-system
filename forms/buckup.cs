using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace elly_gym.forms
{
    public partial class buckup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RH94TE5\\SQLEXPRESS;Initial Catalog=elly_gym;Integrated Security=True");


        public buckup()
        {
            InitializeComponent();
           
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "backup DATABASE elly_gym to disk ='" + packup_path.Text + "\\" + "elly_gym" + "_" + DateTime.Now.ToString("yyyy-MM-dd@HH-mm-ss") + ".bak'";
                cmd.ExecuteNonQuery();
                con.Close();
                //con.Dispose();

                MessageBox.Show("تم عمل نسخه احتياطية");
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql1 = "Alter Database elly_gym Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();
               string sql2 = "USE MASTER RESTORE DATABASE [elly_gym] FROM  DISK = '"+restore_path.Text+"' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(sql2,con);
                cmd2.ExecuteNonQuery();
                string sql3 = "Alter Database elly_gym Set MULTI_USER";
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();
                con.Close();
                //con.Dispose();
                MessageBox.Show("تم اعادة البينات بنجاح");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buckup_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                packup_path.Text = dlg.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files (*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                restore_path.Text = dlg.FileName;
            }
        }

       
    }
}
