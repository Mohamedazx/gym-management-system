using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Data;
using System.Data.SqlClient;

namespace elly_gym.PL
{
    class mortbat
    {

        public void new_salary(int id,
          string name,
          DateTime serial,
          double mop,
          double addres,
          double come,
          double go,
          string note
         )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = name;
            p[2] = new SqlParameter("@date", SqlDbType.Date);
            p[2].Value = serial;
            p[3] = new SqlParameter("@salary", SqlDbType.Float);
            p[3].Value = mop;
            p[4] = new SqlParameter("@hwafes", SqlDbType.Float);
            p[4].Value = addres;
            p[5] = new SqlParameter("@5asm", SqlDbType.Float);
            p[5].Value = come;
            p[6] = new SqlParameter("@total", SqlDbType.Float);
            p[6].Value = go;
            p[7] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            p[7].Value = note;



            ob.RUA("new_salary", p);
            ob.close();
        }


        public void abdate_salary(int id,
          string name,
          DateTime serial,
          double mop,
          double addres,
          double come,
          double go,
          string note
         )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = name;
            p[2] = new SqlParameter("@date", SqlDbType.Date);
            p[2].Value = serial;
            p[3] = new SqlParameter("@salary", SqlDbType.Float);
            p[3].Value = mop;
            p[4] = new SqlParameter("@hwafes", SqlDbType.Float);
            p[4].Value = addres;
            p[5] = new SqlParameter("@5asm", SqlDbType.Float);
            p[5].Value = come;
            p[6] = new SqlParameter("@total", SqlDbType.Float);
            p[6].Value = go;
            p[7] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            p[7].Value = note;



            ob.RUA("abdate_salary", p);
            ob.close();
        }
        public DataTable show_salary_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_salary_id", null);
            ob.close();
            return dt;
        }

        public DataTable vew_salary()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("vew_salary", null);
            ob.close();
            return dt;
        }
        public void delete_salary(int pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@p_ID", SqlDbType.Int);
            p[0].Value = pat_id;
            ob.RUA("delete_salary", p);
            ob.close();
        }

        public DataTable search_salary_date(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("searh_salary_date", p);
            ob.close();
            return dt;
        }
        public DataTable all_trancfare()
        {
            DataTable dt = new DataTable();
            DataTable ds = new DataTable();
            DataTable df = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("all_trancfare", null); 
        
            ob.close();
            return dt;
          
        }
        public DataTable allbills()
        {
            DataTable dt = new DataTable();
          
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("allbills", null);

            ob.close();
            return dt;

        }
        public DataTable allsalary()
        {
            DataTable dt = new DataTable();
           
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("allsalary", null);

            ob.close();
            return dt;

        }
        public DataTable search_for_cost_players(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("search_for_cost_players", p); 
            ob.close();
            return dt;
        }
        public DataTable all_bills_s(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("all_bills_s", p); 
            ob.close();
            return dt;
        }

        public DataTable all_salary_s(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("all_salary_s", p);
            ob.close();
            return dt;
        }

    }
}
