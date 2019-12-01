using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=demo;Integrated Security=True");
            string sQuery = "";
            if(Request["id"]!=null)
            {
                sQuery = "select * from sp where id=" + Request["id"];
                SqlDataAdapter lst = new SqlDataAdapter(sQuery, con);
                DataTable sp = new DataTable();
                lst.Fill(sp);
                txt_name.Text = sp.Rows[0]["name"].ToString();
                Image1.Visible = true;
                Image1.ImageUrl = "~/img/" + sp.Rows[0]["img"].ToString();
                ddl_stt.SelectedValue = sp.Rows[0]["stt"].ToString();
                btn_submit.Text = "Update";
            }
            sQuery = "Select * from sanpham";
            if (Request["key"] != null)
            {
                sQuery = sQuery + " where name like '%" + Request["key"].ToString() + "%'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            int so_item_1trang = 3;
            int so_trang = dt.Rows.Count / so_item_1trang + (dt.Rows.Count % so_item_1trang==0?0:1);
            int page = Request["page"] == null?1:Convert.ToInt32(Request["page"]);
            int from = (page-1)*3;
            int to = page*3-1;
            for (int i = dt.Rows.Count - 1; i >= 0;i-- )
            {
                if(i<from || i>to)
                {
                    dt.Rows.RemoveAt(i);
                }
            }
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            DataTable dtPage = new DataTable();
            dtPage.Columns.Add("index");
            dtPage.Columns.Add("active");
            for(int i=1;i<=so_trang;i++)
            {
                DataRow dr = dtPage.NewRow();
                dr["index"] = i;
               
                if ((Request["page"] == null && i == 1) || (Request["page"] != null && Convert.ToInt32(Request["page"]) == i))
                    dr["active"]=1;
                else
                    dr["active"] = 0;
                dtPage.Rows.Add(dr);
            }
            Repeater2.DataSource = dtPage;
            Repeater2.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx?key=" + txtKey.Text);
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            if(btn_submit.Text=="Add")
            {
                //xu li them
            }
            else
            {
                //xu li update
            }
        }
    }
}