<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddClass.aspx.cs" Inherits="Ajax.AddClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="Button1" type="button" value="button" />
        </div>
        <script src="js/jquery-3.4.1.min.js"></script>
        <script>
            $('#Button1').click(function () {
                $('#Button1').addClass('selected');
            });
        </script>
    </form>
</body>
</html>
