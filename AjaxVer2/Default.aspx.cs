using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
namespace AjaxVer2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Click ASPX')</script>");
        }
       

        [WebMethod]
        public static string SaveData(string name, string phone, string email, string address)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLSP;Integrated Security=True");
            conn.Open();
            String sQuery = "INSERT INTO [dbo].[Student] ([Name] ,[Phone] ,[Email] ,[Address]) VALUES ('" + name + "', '" + phone + "','" + email + "','" + address + "')";
            SqlCommand cmd = new SqlCommand(sQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Submit";
        }
    }
}