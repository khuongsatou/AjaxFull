using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GirdViewDB
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName=="x")
            {
                SqlDataSource1.DeleteParameters["MaL"].DefaultValue = DataList1.DataKeys[e.Item.ItemIndex].ToString();
                SqlDataSource1.Delete();
            }
            if (e.CommandName == "s")
            {
                DataList1.EditItemIndex = e.Item.ItemIndex;
                DataList1.DataBind();
            }
            if (e.CommandName == "h")
            {
                DataList1.EditItemIndex = -1;
                DataList1.DataBind();
            }
            if (e.CommandName == "c")
            {
                TextBox t = new TextBox();
                t= (TextBox) e.Item.FindControl("");
                SqlDataSource1.UpdateParameters["key"].DefaultValue = t.Text;
                SqlDataSource1.Update();
                DataList1.EditItemIndex = -1;
                DataList1.DataBind();
            }
        }
    }
}