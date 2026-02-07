using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Data;
using System.Data.SqlClient;


namespace elly_gym.PL
{
    class players_pl
    {
        public void new_player(int id,
           string name,          
           string serial,
           string mop,
           string addres,
           DateTime come,
           DateTime go,
           string total_day,
           double cost,
           string note,
           DateTime date_time,
           string block
          )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[12];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = name;
            p[2] = new SqlParameter("@serial", SqlDbType.NVarChar, 50);
            p[2].Value = serial;
            p[3] = new SqlParameter("@phone", SqlDbType.NVarChar, 11);
            p[3].Value = mop;
            p[4] = new SqlParameter("@adress", SqlDbType.NVarChar, 50);
            p[4].Value = addres;
            p[5] = new SqlParameter("@date_come", SqlDbType.Date);
            p[5].Value = come;
            p[6] = new SqlParameter("@date_go", SqlDbType.Date);
            p[6].Value = go;
            p[7] = new SqlParameter("@total_day", SqlDbType.NVarChar, 50);
            p[7].Value = total_day;
            p[8] = new SqlParameter("@cost", SqlDbType.Float);
            p[8].Value = cost;
            p[9] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            p[9].Value = note;
            p[10] = new SqlParameter("@date_time", SqlDbType.DateTime);
            p[10].Value = date_time;
            p[11] = new SqlParameter("@block", SqlDbType.NVarChar, 50);
            p[11].Value = block;


            ob.RUA("new_playerss", p);
            ob.close();
        }


        public void update_player(int id,
           string name,
           string serial,
           string mop,
           string addres,
           DateTime come,
           DateTime go,
           string total_day,
           double cost,
           string note,
           string block
          )
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[11];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[1].Value = name;
            p[2] = new SqlParameter("@serial", SqlDbType.NVarChar, 50);
            p[2].Value = serial;
            p[3] = new SqlParameter("@phone", SqlDbType.NVarChar, 11);
            p[3].Value = mop;
            p[4] = new SqlParameter("@adress", SqlDbType.NVarChar, 50);
            p[4].Value = addres;
            p[5] = new SqlParameter("@date_come", SqlDbType.Date);
            p[5].Value = come;
            p[6] = new SqlParameter("@date_go", SqlDbType.Date);
            p[6].Value = go;
            p[7] = new SqlParameter("@total_day", SqlDbType.NVarChar, 50);
            p[7].Value = total_day;
            p[8] = new SqlParameter("@cost", SqlDbType.Float);
            p[8].Value = cost;
            p[9] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            p[9].Value = note;
            p[10] = new SqlParameter("@block", SqlDbType.NVarChar, 50);
            p[10].Value = block;


            ob.RUA("update_player", p);
            ob.close();
        }
        public void update_player_come(int id,
          DateTime name,string date)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[3];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            p[1] = new SqlParameter("@date_come", SqlDbType.Date);
            p[1].Value = name;
            p[2] = new SqlParameter("@time", SqlDbType.NVarChar,50);
            p[2].Value = date;

            ob.RUA("add_come", p);
            ob.close();

        }
        public DataTable show_user_id()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("show_user_id", null);
            ob.close();
            return dt;
        }
        public DataTable show_time(int id)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            ob.open();
            dt = ob.Reader("show_date", p);
            ob.close();
            return dt;
        }


        public DataTable vew_all_player()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("vew_all_player", null);
            ob.close();
            return dt;
        }

        public DataTable vew_com_player()
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            dt = ob.Reader("vew_come_player", null);
            ob.close();
            return dt;
        }

        public void delete_blayer(int pat_id)
        {
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@p_ID", SqlDbType.Int);
            p[0].Value = pat_id;
            ob.RUA("delete_blayer", p);
            ob.close();
        }
        public DataTable search_player_info(string patient_name)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[0].Value = patient_name;
            dt = ob.Reader("search_player", p);
            ob.close();
            return dt;
        }
        public DataTable search_comes_info(string patient_id)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = patient_id;
            dt = ob.Reader("search_come", p);
            ob.close();
            return dt;
        }
        public DataTable search_player_date(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            Dxl ob = new Dxl();
            ob.open();
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@date1", SqlDbType.Date);
            p[0].Value = d1;
            p[1] = new SqlParameter("@date2", SqlDbType.Date);
            p[1].Value = d2;
            dt = ob.Reader("searh_player_date", p);
            ob.close();
            return dt;
        }
    }
}
