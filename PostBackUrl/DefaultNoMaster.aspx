<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultNoMaster.aspx.cs" Inherits="PostBackUrl.DefaultNoMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" PostBackUrl="~/DefaultNoMaster2.aspx" />
        </div>
    </form>
</body>
</html>
