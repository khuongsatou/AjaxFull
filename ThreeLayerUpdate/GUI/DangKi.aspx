<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKi.aspx.cs" Inherits="GUI.DangKi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Tên tài khoản:</td>
                    <td>
                        <asp:TextBox ID="txtTenTK" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mật khẩu:</td>
                    <td>
                        <asp:TextBox ID="txtMK" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>SDT:</td>
                    <td>
                        <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Địa chỉ:</td>
                    <td>
                        <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Họ tên:</td>
                    <td>
                        <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnDangKi" runat="server" Text="Đăng kí" OnClick="btnDangKi_Click" />
                        <input type="reset" value="Hủy bỏ" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
