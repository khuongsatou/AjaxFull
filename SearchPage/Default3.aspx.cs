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
    public partial class Default3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=demo;Integrated Security=True");
            string sQuery = "SELECT * FROM SANPHAM";
            if (Request["key"] != null)
            {
                sQuery += " WHERE name like '%"+Request["key"]+"%'";
                sQuery += " OR stt like '%" + Request["key"] + "%'";
            }
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sQuery,conn);
            da.Fill(dt);
            Label1.Text ="Số Lượng tìm được: "+ dt.Rows.Count.ToString();


            int gioiHan1Page = 3;
            int soTrang = dt.Rows.Count / gioiHan1Page + (dt.Rows.Count % gioiHan1Page == 0 ? 1 : 0);
            int page = Request["page"] == null ? 1 : Convert.ToInt32(Request["page"]);
            int from = (page - 1) * gioiHan1Page;
            int to = (page * gioiHan1Page) - 1;
            for (int i = dt.Rows.Count-1; i >= 0; i--)
            {
                //count 10
                //phải nhỏ hơn bắt đầu
                //from : 0
                // vị trí i phải hơn hơn vị trí đến.
                //to : 3
                //i= -1 ko remove
                // 10 
                //hoặc 10 > 3 thì remo từ 4-> 10

                if ( i < from || i > to)
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

                //khi chọn vào đâu thì active nó lên
                //thứ trang load đầu
                //trang 2 -> hết trang 
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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default3.aspx?key=" + txtKey.Text);
        }
    }
}