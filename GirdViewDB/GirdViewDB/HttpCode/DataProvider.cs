using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GirdViewDB.HttpCode
{
    public class DataProvider
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLSP;Integrated Security=True");

        public static void connect()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
        }

        public static int ExecNoQuery(string sQuery, SqlParameter[] sParam)
        {
            int rowAff;
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand(sQuery,conn);
                cmd.Parameters.AddRange(sParam);
                rowAff = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception)
            {
                return 0;
            }
            return rowAff;
        }

        public static DataTable ExecQuery(string sQuery, SqlParameter[] sParam)
        {
            DataTable dt = new DataTable();
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand(sQuery, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                cmd.Parameters.AddRange(sParam);
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception)
            {
                return null;
            }
            return dt;
        }


    }
}