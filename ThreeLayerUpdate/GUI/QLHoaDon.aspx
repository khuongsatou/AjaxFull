<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLHoaDon.aspx.cs" Inherits="GUI.QLHoaDon" %>

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
            <td>Mã hoá đơn:</td>
            <td>
                <asp:TextBox ID="txtMaHD" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Tên tài khoản:</td>
            <td>
                <asp:TextBox ID="txtTenTaiKhoan" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Ngày mua:</td>
            <td>
                <asp:TextBox ID="txtNgayMua" TextMode="DateTime" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Địa chỉ giao hàng:</td>
            <td>
                <asp:TextBox ID="txtDiaChiGiaoHang" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Số điện thoại giao hàng:</td>
            <td>
                <asp:TextBox ID="txtSDTGiaoHang" runat="server" TextMode="Number"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Tổng tiền:</td>
            <td>
                <asp:TextBox ID="txtTongTien" TextMode="Number" runat="server"></asp:TextBox></td>
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
        <asp:GridView ID="grvHoaDon" runat="server" AutoGenerateColumns="False" OnRowCommand="grvHoaDon_RowCommand">
            <Columns>
                <asp:BoundField DataField="MaHD" HeaderText="Mã hóa đơn" />
                <asp:BoundField DataField="TenTaiKhoan" HeaderText="Tên tài khoản " />
                <asp:BoundField DataField="NgayMua" HeaderText="Ngày mua" />
                <asp:BoundField DataField="DiaChiGiaoHang" HeaderText="Địa chỉ giao hàng" />
                <asp:BoundField DataField="SDTGiaoHang" HeaderText="Số điện thoại giao hàng" />
                <asp:BoundField DataField="TongTien" HeaderText="Tổng tiền" />
                <asp:CheckBoxField DataField="TrangThai" HeaderText="Trạng Thái" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btnChonHD" runat="server" CausesValidation="False" CommandName="ChonHD" Text="Chọn" CommandArgument='<%# Eval("MaHD") %>' />
                        <asp:Button ID="btnXoaHD" runat="server" CausesValidation="False" CommandName="XoaHD" Text="Xóa" CommandArgument='<%# Eval("MaHD") %>' OnClientClick="return comfirm('Bạn có chắc muốn xóa không?'); " />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
       </asp:GridView>
    </div>
    </form>
</body>
</html>
