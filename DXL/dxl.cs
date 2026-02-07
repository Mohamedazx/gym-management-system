using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace elly_gym
{
    class Dxl
    {
        SqlCommand cmd;
        SqlDataAdapter da;

        SqlConnection cn;
        DataTable dt = new DataTable();

        public  Dxl()  /*  باني افتراضي لاجل بناء اتصال */
        {
            cn = new SqlConnection("Data Source=DESKTOP-RH94TE5\\SQLEXPRESS;Initial Catalog=elly_gym;Integrated Security=True");
            /*Data Source=DESKTOP-RH94TE5;Initial Catalog=Dentist;Persist Security Info=True;User ID=hosny;Password=*********** */
            /*"server=192.168.1.10,1433;Initial Catalog=Dentist;  User ID=hosny;Password=Hosnyaz123"*/

        }

        public void open()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        public void close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

       

        // لقراءة البيانات من قاعدة البيانات
        public DataTable Reader(string sp, SqlParameter[] p)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = cn;
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;


        }
        //Remove ,Update ,Add
        public void RUA(string sp, SqlParameter[] p)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = cn;
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            cmd.ExecuteNonQuery();

        }
    }
}
