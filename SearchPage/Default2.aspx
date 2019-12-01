<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="SearchPage.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <asp:Repeater ID="rptList" runat="server">
                <ItemTemplate>

                    <tr>
                        
                        <td style='background-color:<%#Convert.ToInt32(Eval("id")) %2==0 ? "red":"yellow" %>' ><%# Eval("id") %></td>
                        <td><%# Eval("name") %></td>
                        <td><%# Eval("img") %></td>
                        <td><%# Eval("stt") %></td>
                    </tr>

                </ItemTemplate>

            </asp:Repeater>
            <asp:Repeater ID="rpt_phanTrang" runat="server">
                <ItemTemplate>
                    <a href="?page=
                        <%#Eval("index") %><% if (Request["key"] != null) Response.Write("&key=" + Request["key"]); %><% if (Request["id"] != null) Response.Write("&id=" + Request["id"]); %>" style="background-color:<%# (Eval("active").ToString()=="1"?"yellow":"white")%>"><%#Eval("index") %></a>
                </ItemTemplate>
            </asp:Repeater>
        </table>
     
    </form>
</body>
</html>
