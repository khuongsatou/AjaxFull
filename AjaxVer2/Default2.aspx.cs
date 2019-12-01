using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
namespace AjaxVer2
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Click_Button1(object sender, EventArgs e)
        {
            Label1.Text = "Click Code Behind";
        }

        [WebMethod]
        public static string alert(string name)
        {
            

            return name;
        }
    }
}