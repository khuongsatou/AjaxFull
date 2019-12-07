<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLTaiKhoan.aspx.cs" Inherits="GUI.QLTaiKhoan" %>

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
                        <asp:TextBox ID="txtTenTaiKhoan" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mật khẩu:</td>
                    <td>
                        <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>SĐT:</td>
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
                    <td>Là admin:</td>
                    <td>
                        <asp:CheckBox ID="chkLaAdmin" runat="server" /></td>
                </tr>
                <tr>
                    <td>Ảnh đại diện</td>
                    <td>
                        <asp:TextBox ID="txtAnhDaiDien" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Trạng thái:</td>
                    <td>
                        <asp:CheckBox ID="chkTrangThai" runat="server" Checked="true" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
                        <asp:Button ID="btnSua" runat="server" Text="Sửa" Enabled="false" OnClick="btnSua_Click" />
                        <asp:Button ID="btnHuy" runat="server" Text="Hủy bỏ" OnClick="btnHuy_Click" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="grvTaiKhoan" runat="server" AutoGenerateColumns="False" OnRowCommand="grvDSTaiKhoan_RowCommand">
                <Columns>
                    <asp:BoundField DataField="TenTaiKhoan" HeaderText="Tên tài khoản" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="SDT" HeaderText="SĐT" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
                    <asp:BoundField DataField="HoTen" HeaderText="Họ tên" />
                    <asp:CheckBoxField DataField="LaAdmin" HeaderText="Là admin" />
                    <asp:BoundField DataField="AnhDaiDien" HeaderText="Ảnh đại diện" />
                    <asp:CheckBoxField DataField="TrangThai" HeaderText="Trạng thái" />
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnChon" runat="server" CausesValidation="False" CommandName="ChonTK" CommandArgument='<%# Eval("TenTaiKhoan") %>' Text="Chọn" />
                            <asp:Button ID="btnXoa" runat="server" CausesValidation="False" CommandName="XoaTK" CommandArgument='<%# Eval("TenTaiKhoan") %>' Text="Xóa" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa?');" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
