<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultAjaxBasic.aspx.cs" Inherits="Ajax.DefaultAjaxBasic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function loadAjax() {
            alert("Clicked");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="submit" type="Submit" value="Submit" onclick="loadAjax()" />
        </div>
    </form>
</body>
</html>
