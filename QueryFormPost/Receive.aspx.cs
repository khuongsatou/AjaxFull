using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryFormPost
{
    public partial class Receive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["txtUserName"] != null)
            {
                lblUserName.Text = Request.Form["txtUserName"];
                lblPassWord.Text = Request.Form["txtPassWord"];
            }
        }

       
      
    }
}