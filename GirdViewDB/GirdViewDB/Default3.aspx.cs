using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GirdViewDB
{
    public partial class Default3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow r = GridView1.SelectedRow;
            TextBox1.Text = r.Cells[1].Text;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}