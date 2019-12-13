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
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=db;Integrated Security=True");
            conn.Open();
            string sQuery = "SELECT * FROM [tbSanPham]";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            
            if (Request["key"] != null)
            {
                //SELECT * FROM [tbSanPham] WHERE (([TenSP] LIKE '%' + @TenSP + '%') AND ([MoTa] LIKE '%' + @MoTa + '%'))
                sQuery += " WHERE (([TenSP] LIKE '%' + @TenSP + '%') OR ([MoTa] LIKE '%' + @MoTa + '%'))";
                SqlParameter[] param = {
                    new SqlParameter("TenSP",Request["key"].ToString()),
                    new SqlParameter("MoTa", Request["key"].ToString())
                };
                cmd.Parameters.AddRange(param);
                //SELECT * FROM [tbSanPham] WHERE (([TenSP] LIKE '%' + @TenSP + '%') AND ([MoTa] = @MoTa))

            }
            cmd.CommandText = sQuery;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
           

            int limit = 5;
            int soTrang = dt.Rows.Count / limit + (dt.Rows.Count % limit == 0 ?0:1);
            int page = Request["page"] == null ? 1 : Convert.ToInt32(Request["page"]);
            int from = (page - 1) * limit;
            int to = (page * limit) -1 ;
            for (int i = dt.Rows.Count-1; i >= 0; i--)
            {
                // i<from----------to <i
                if (i<from || to < i)
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
                if ((Request["page"] == null && i==1) || (Request["page"] != null && Convert.ToInt32(Request["page"]) == i))
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
            Response.Redirect("Default1.aspx?key=" + TextBox1.Text);
        }
    }
}