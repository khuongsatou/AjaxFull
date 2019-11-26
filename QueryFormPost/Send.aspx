<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Send.aspx.cs" Inherits="QueryFormPost.Send" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUserName" runat="server" placeholder="user name..."></asp:TextBox>
            <asp:TextBox ID="txtPassWord" runat="server"  placeholder="pass word..."></asp:TextBox>
            <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="BtnSend_Click" />
        </div>
    </form>
</body>
</html>
