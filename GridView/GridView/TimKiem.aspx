<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TimKiem.aspx.cs" Inherits="GridView.TimKiem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:DataList ID="DataList1" runat="server" DataKeyField="MaL" >
            <ItemTemplate>
                MaL:
                <asp:Label ID="MaLLabel" runat="server" Text='<%# Eval("MaL") %>' />
                <br />
                TenLoai:
                <asp:Label ID="TenLoaiLabel" runat="server" Text='<%# Eval("TenLoai") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
       
    </form>
</body>
</html>
