using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackUrl
{
    public partial class DefaultNoMaster2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["TextBox1"] !=null)
            {
                Label1.Text = Request.Form["TextBox1"];
            }
            else
            {
                Label1.Text ="NULL";
            }
        }
    }
}