using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AjaxVer2
{
    public class DataProvider
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLSP;Integrated Security=True");

        public static void connect()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception)
                {
                    throw new System.ArgumentException("Chua connect", "connect string");
                }
            }
        }

        public static DataTable ExecuteQuery(string sQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                connect();
                SqlDataAdapter da = new SqlDataAdapter(sQuery, conn);
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception)
            {
                return null;
            }
            return dt;
        }

        public static int ExecuteNonQuery(string sQuery)
        {
            int rowSuccess = 0;
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand(sQuery, conn);
                rowSuccess = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                return 0;
            }
            return rowSuccess;
        }

    }
}