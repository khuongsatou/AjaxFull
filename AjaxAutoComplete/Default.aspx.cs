using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxAutoComplete
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLSP;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAISP", conn);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();


            gvList.DataSource = dt;
            gvList.DataBind();
        }
    }
}