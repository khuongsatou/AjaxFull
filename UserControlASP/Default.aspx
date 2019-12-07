<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserControlASP.Default" %>

<%@ Register Src="~/ContactUC.ascx" TagPrefix="uc1" TagName="ContactUC" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:ContactUC runat="server" ID="ContactUC" Header="Đây Là UserControl" />
        </div>
    </form>
</body>
</html>
