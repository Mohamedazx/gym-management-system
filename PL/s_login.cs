using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Data;
using System.Data.SqlClient;


namespace elly_gym.PL
{
    class s_login
    {
        public DataTable cutsh_type()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("cutsh_type", null);
            ob.close();
            return dt;
        }
        public void set_user(string name, string type
     )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[0].Value = name;
            p[1] = new SqlParameter("@user", SqlDbType.NVarChar, 50);
            p[1].Value = type;
            ob.RUA("set_user", p);
            ob.close();
        }
        public DataTable slogin(string user_name, string user_password, string user_type)

        {
            Dxl ob = new Dxl();


            DataTable dt = new DataTable();
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            p[0].Value = user_name;
            p[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            p[1].Value = user_password;
            p[2] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            p[2].Value = user_type;
            ob.open();
            dt = ob.Reader("S_login", p);

            return dt;
            //ob.close();

        }
    }
}
