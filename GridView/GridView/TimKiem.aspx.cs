using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView
{
    public partial class TimKiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLSP;Integrated Security=True");

            conn.Open();

            //String sQuery = "SELECT * FROM LoaiSP";
            string sQuery = "SELECT * FROM SanPham,LoaiSP WHERE MAL=MaLoai ";
            if (TextBox1.Text != "")
            {
                sQuery += " and MAL LIKE N'%" + TextBox1.Text + "%'";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            DataList1.DataSource = dt;
            DataList1.DataBind();
            
        }
    }
}