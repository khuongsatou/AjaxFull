using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackUrl.Admin
{
    public partial class DefaultThem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.PreviousPage != null)
            {
                Label1.Text = "NOT NULL";
            }
            else
            {
                Label1.Text = "NULL";
            }
        }
    }
}