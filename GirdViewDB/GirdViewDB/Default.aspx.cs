using GirdViewDB.HttpCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GirdViewDB
{
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
            }
        }
        protected void BtnTim_Click(object sender, EventArgs e)
        {
            string sQuery = "SELECT * FROM SanPham,LoaiSP WHERE MaL=MaLoai ";
            string ten = txtTen.Text;
            

            if (txtTen.Text != "")
            {
                sQuery += " and Ten LIKE N'%"+ ten + "%' ";
            }
            if(txtGiaTu.Text != "")
            {
                int giaTu = Convert.ToInt32(txtGiaTu.Text);
                sQuery += " and Gia >=" + giaTu + " ";
            }
            SqlParameter[] pa ={ };
            DataTable dt =  DataProvider.ExecQuery(sQuery, pa);

            Response.Write(dt.Rows[0][0]+"");
            Response.Write(dt.Rows[0][1] + "");
        }


        
    }
}