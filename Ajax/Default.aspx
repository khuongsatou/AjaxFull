﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ajax.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Name</td>
                <td>
                    <input id="txt_name" type="text" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Phone</td>
                <td>
                    <input id="txt_phone" type="text" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td>
                    <input id="txt_email" type="text" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Address</td>
                <td>
                    <input id="txt_address" type="text" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <%-- <asp:Button ID="btnAdd" runat="server" Text="Add" />--%>
                    <input id="Button1" type="button" value="button" onclick="AjaxTest()" />
                    <%--<input id="btnAdd" type="submit" value="Add" onclick="AjaxTest()" />--%>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <script src="js/jquery-3.4.1.min.js"></script>
        <script>
            $(document).ready(function () {
                //pageLoad
            });
            function AjaxTest() {
                var name = $('#txt_name').val();
                var phone = $('#txt_phone').val();
                var email = $('#txt_email').val();
                var address = $('#txt_address').val();
                if (name == "" || phone == "" || email == "" || address == "") {
                    alert("Please enter all the fields");
                    return false;
                }
                $.ajax({
                    type: "POST",
                    contentType: "application/json",
                    // Thành công. vì gọi chính nó
                    url: "Default.aspx/SaveData",
                    data: "{'name':'" + name + "','phone':'" + phone + "', 'email': '" + email + "', 'address':'" + address + "'}",
                    datatype: "json",
                    success: function (data) {
                        //Show_data();
                        alert("Submit Successfully");
                        //ClearField();
                    },
                    error: function (response) {
                        alert(response.d + "Có Lỗi");
                    }

                });
            }
        </script>
    </form>
</body>
</html>
