<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UploadImage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:FileUpload ID="fuImage" runat="server" />
            <asp:Button ID="btnTai" runat="server" Text="Tải" OnClick="btnTai_Click" />
            <asp:Label ID="lblThongBao" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
