<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default3.aspx.cs" Inherits="SearchPage.Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <%--  <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <asp:Image ID="Image1" runat="server" Height="118px" Visible="False" Width="121px" />
            <asp:FileUpload ID="ful_img" runat="server" />
            <asp:DropDownList ID="ddl_stt" runat="server">
                <asp:ListItem Value="1">Active</asp:ListItem>
                <asp:ListItem Value="0">Disabled</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btn_submit" runat="server" Text="Add" OnClick="btn_submit_Click" />
            <br />--%>
            <div>
                <asp:TextBox ID="txtKey" runat="server"></asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                <asp:Label ID="Label1" runat="server" Text="Số Lượng:"></asp:Label>
            </div>

            <table style="width: 50%;">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("id") %></td>
                            <td><%# Eval("name") %></td>
                            <td>
                                <asp:Image Width="50px" Height="50px" ID="Image1" runat="server" ImageUrl='<%# Eval("img","~/img/{0}") %>' /></td>
                            <td><%# Eval("stt") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <div>
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <a href='?page=<%#Eval("index") %><%if (Request["key"] != null) Response.Write("&key="+txtKey.Text); %>' style='background-color: <%# Convert.ToInt32(Eval("active")) == 1 ? "yellow" : "white" %>'><%# Eval("index") %></a>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
