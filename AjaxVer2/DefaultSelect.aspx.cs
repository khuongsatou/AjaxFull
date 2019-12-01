using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;

namespace AjaxVer2
{
    public partial class DefaultSelect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static LOAiSP[]  select()
        {
            DataTable dt = LOAiSP.getList();
            List<LOAiSP> ls = new List<LOAiSP>();
            foreach (DataRow r in dt.Rows)
            {
                LOAiSP l = new LOAiSP();
                l.MaL = Convert.ToInt32(r["MaL"]);
                l.TenLoai = r["TenLoai"].ToString();
                ls.Add(l);
            }
            return ls.ToArray();
        }
    }
}