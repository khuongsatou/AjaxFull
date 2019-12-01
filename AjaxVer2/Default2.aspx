<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="AjaxVer2.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Click_Button1" Text="Button" OnClientClick="loadAjax();return false;" />
           <%-- <input id="Button1" type="submit" value="button" onclick="loadAjax()" />--%>

        </div>

         <script src="js/jquery-3.4.1.min.js"></script>
        <script>

            function loadAjax() {
                var txt = $('#TextBox1').val();
                if (txt=="") {
                    alert("chưa nhập");
                    return;
                }
                var json = "'name':'"+txt+"'";
                $.ajax({
                    type: "POST",
                    url: "Default2.aspx/alert",
                    data: "{" + json+"}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        alert("Đã Lấy được hàm:" + msg.d);
                        
                        // Do something interesting with msg.d here.
                    },
                    error: function (response) {
                        alert("msg" + response.d);
                    }
                });
            }
        </script>
    </form>


</body>
</html>
