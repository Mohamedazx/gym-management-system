using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace elly_gym.PL
{
    class srevers
    {
        public DataTable vew_server_name()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("sql_reder", null);
            ob.close();
            return dt;
        }
        public DataTable vew_database_name()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("data_base", null);
            ob.close();
            return dt;
        }

        public void back_up(string pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@file", SqlDbType.NVarChar,300);
            p[0].Value = pat_id;
            ob.RUA("pack_up", p);
            ob.close();
        }

    }
}
