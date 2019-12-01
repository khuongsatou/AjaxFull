using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SearchPage
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=demo;Integrated Security=True");
            conn.Open();
            string sQuery = "";
            if (Request["id"]!=null)
            {
                //sQuery = "select * from sp where id =" + Request["id"];
                //conn.Open();
                //SqlDataAdapter da = new SqlDataAdapter(sQuery, conn);
                //DataTable dt = new DataTable();
                //da.Fill(dt);

            }
            sQuery = "Select * from sanpham";
            if (Request["key"] != null)
            {
                sQuery = sQuery + " where name like '%" + Request["key"].ToString() + "%'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sQuery, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int so_item_1_trang = 3;
            int so_trang = dt.Rows.Count / so_item_1_trang + (dt.Rows.Count % so_item_1_trang == 0 ? 0 : 1);
            int page = Request["page"] == null ? 1 : Convert.ToInt32(Request["page"]);
            int from = (page - 1) * 3;
            int to = page * 3 - 1;
            for (int i = dt.Rows.Count -1; i >= 0; i--)
            {
                if (i<from || i > to)
                {
                    dt.Rows.RemoveAt(i);
                }
            }
            rptList.DataSource = dt;
            rptList.DataBind();
            DataTable dtPage = new DataTable();
            dtPage.Columns.Add("index");
            dtPage.Columns.Add("active");
            for (int i =1; i <= so_trang ;i++)
            {
                DataRow dr = dtPage.NewRow();
                dr["index"] = i;

                if ((Request["page"] == null &&  i == 1) || (Request["page"] !=null && Convert.ToInt32(Request["page"]) == i))
                {
                    dr["active"] = 1;
                    
                }
                else
                {
                    dr["active"] = 0;
                }
                dtPage.Rows.Add(dr);
            }
            rpt_phanTrang.DataSource = dtPage;
            rpt_phanTrang.DataBind();



        }
    }
}