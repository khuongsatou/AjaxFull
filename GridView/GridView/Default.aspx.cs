using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace GridView
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow r = GridView1.SelectedRow;
            txtTen.Text = r.Cells[2].Text;
            txtGiaBan.Text = r.Cells[3].Text;
            txtGhiChu.Text = r.Cells[5].Text;
            DropDownList1.SelectedValue = r.Cells[6].Text;

        }




    }
}