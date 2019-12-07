using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace PostBackUrl
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.PreviousPage != null)
            {
                ContentPlaceHolder content = (ContentPlaceHolder)Page.PreviousPage.Form.FindControl("contentPage");
                string page =((TextBox)content.FindControl("txtNhap")).Text;
                //string page = Request.Form["txtNhap"];
                Label1.Text = "NOT NULL"+page;
            }
            else
            {
                Label1.Text = "NULL";
            }
        }
    }
}