using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Data;
using System.Data.SqlClient;

namespace elly_gym.PL
{
    class bills
    {

        public void new_bill(int id,float amount,DateTime date,string note)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@amount", SqlDbType.Float);
            p[1].Value = amount;
            p[2] = new SqlParameter("@date", SqlDbType.Date);
            p[2].Value = date;
            p[3] = new SqlParameter("@note", SqlDbType.NVarChar ,50);
            p[3].Value = note;
            ob.RUA("new_bill", p);
            ob.close();
        }

        public DataTable show_bill_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_bill_id", null);
            ob.close();
            return dt;
        }

        public DataTable vew_bill()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("vew_bills", null);
            ob.close();
            return dt;
        }
        public void delete_bill(int pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@p_ID", SqlDbType.Int);
            p[0].Value = pat_id;
            ob.RUA("delete_bill", p);
            ob.close();
        }

        public DataTable search_bill_date(DateTime d1,DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("searh_bill_date", p);
            ob.close();
            return dt;
        }
    }
}
