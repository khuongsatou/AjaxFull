<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JqueryBasic.aspx.cs" Inherits="Ajax.JqueryBasic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        //web load xong
        window.onload = function () {
            alert("Đoạn thứ 3 load xong");
        };
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" id="id-textbox" value="" />
            <br />
            <input type="button" id="id-button" value="Alert" /><br>
        </div>

        <script src="<%=ResolveUrl("~") %>js/jquery-3.4.1.min.js"></script>
        <script>
            alert("Đoạn 1");
            alert("Đoạn 2");
           
            $('#id-button').click(function () {
                alert($('#id-textbox').val());
            });
            alert("Đoạn 4 end");
        </script>
    </form>
</body>
</html>
