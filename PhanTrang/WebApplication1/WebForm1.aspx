<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txt_name" runat="server" ValidationGroup="add"></asp:TextBox>
        <asp:Image ID="Image1" runat="server" Height="118px" Visible="False" Width="121px" />
        <asp:FileUpload ID="ful_img" runat="server" />
        <asp:DropDownList ID="ddl_stt" runat="server">
            <asp:ListItem Value="1">Active</asp:ListItem>
            <asp:ListItem Value="0">Disabled</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btn_submit" runat="server" Text="Add" OnClick="btn_submit_Click" ValidationGroup="add" />
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_name" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />
        <div>
            <asp:TextBox ID="txtKey" runat="server" ValidationGroup="search"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" ValidationGroup="search" />
        </div>
        <table>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>

                        <td style='background-color:<%# (Convert.ToInt32(Eval("ID").ToString())%2==0?"red":"blue")%>;'><%#Eval("ID")%> 
                            </td>
                        <td><%#Eval("name")%></td>
                        <td>
                            <img src="img/<%#Eval("img")%>" style="width:100px;height:100px;" alt="Alternate Text" /></td>
                        <td><%# (Eval("stt").ToString()=="1"?"Active":"Disabled")%></td>
                        <td><a href="?id=<%#Eval("id")%>">Edit</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </table>
        <div>
            <asp:Repeater ID="Repeater2" runat="server">
                <ItemTemplate>
                    <a href="?page=<%#Eval("index") %><% if (Request["key"] != null) Response.Write("&key=" + Request["key"]); %><% if (Request["id"] != null) Response.Write("&id=" + Request["id"]); %>" style="background-color:<%# (Eval("active").ToString()=="1"?"yellow":"white")%>"><%#Eval("index") %></a>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>

</body>
</html>
