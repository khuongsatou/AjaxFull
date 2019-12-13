using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnPaging
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=db;Integrated Security=True");
            conn.Open();
            string sQuery = "SELECT * FROM [tbSanPham]";
            if (Request["key"] !=null)
            {
                sQuery += " WHERE TenSP like N'%" + Request["key"] + "%' ";
                sQuery += " OR MoTa like N'%" + Request["key"] + "%' ";
            }



            SqlDataAdapter da = new SqlDataAdapter(sQuery,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int count = 0;
            foreach (DataRow dr in dt.Rows)
            {
                count++;
            }
            Label1.Text = count + "";

            int limit = 5;
            int soTrang = (dt.Rows.Count / limit) + (dt.Rows.Count % limit == 0 ? 0 : 1);
            int page = Request["page"] == null ? 1 : Convert.ToInt32(Request["page"]);
            int from = (page-1)*limit;
            int to = (page * limit) - 1;

            for (int i = dt.Rows.Count-1; i >= 0; i--)
            {
                // xxx i > from--------------to < i xxx
                if ( from > i || to < i)
                {
                    dt.Rows.RemoveAt(i);
                }
            }

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            
            

            DataTable dtp = new DataTable();
            dtp.Columns.Add("index");
            dtp.Columns.Add("active");
            for (int i = 1; i <= soTrang; i++)
            {
                DataRow dr = dtp.NewRow();
                dr["index"] = i;
                if ((Request["page"] == null && i == 1) || (Request["page"] !=null && Convert.ToInt32(Request["page"]) == i))
                {
                    dr["active"] = 1;
                }
                else
                {
                    dr["active"] = 0;
                }
                dtp.Rows.Add(dr);
            }

            Repeater2.DataSource = dtp;
            Repeater2.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("Default.aspx?key="+TextBox1.Text);
        }
    }
}