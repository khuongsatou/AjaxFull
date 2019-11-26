using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryFormPost
{
    public partial class Send : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSend_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="123" && txtPassWord.Text =="456")
            {
                btnSend.PostBackUrl = "~/Receive.aspx";
            }
        }
    }
}