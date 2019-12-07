<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLSanPham.aspx.cs" Inherits="GUI.QLSanPham1" %>

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
                <td>Mã sản phẩm:</td>
                <td>
                    <asp:TextBox ID="txtMaSP" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tên sản phẩm:</td>
                <td>
                    <asp:TextBox ID="txtTenSP" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Thông tin:</td>
                <td>
                    <asp:TextBox ID="txtThongTin" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Giá tiền:</td>
                <td>
                    <asp:TextBox ID="txtGiaTien" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Số lượng tồn kho:</td>
                <td>
                    <asp:TextBox ID="txtSoLuongTonKho" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Mã loại sản phẩm:</td>
                <td>
                    <asp:TextBox ID="txtMaLoaiSP" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Ảnh minh họa</td>
                <td>
                    <asp:TextBox ID="txtAnhMinhHoa" runat="server"></asp:TextBox></td>
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
        <asp:GridView ID="grvSanPham" runat="server" AutoGenerateColumns="False" OnRowCommand="grvSanPham_RowCommand">
            <Columns>
                <asp:BoundField DataField="MaSP" HeaderText="Mã sản phẩm" />
                <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
                <asp:BoundField DataField="ThongTin" HeaderText="Thông tin" />
                <asp:BoundField DataField="GiaTien" HeaderText="Giá tiền" />
                <asp:BoundField DataField="SoLuongTonKho" HeaderText="Số lượng tồn kho" />
                <asp:BoundField DataField="MaLoaiSP" HeaderText="Mã loại sản phẩm" />
                <asp:BoundField DataField="AnhMinhHoa" HeaderText="Ảnh minh họa" />
                <asp:CheckBoxField DataField="TrangThai" HeaderText="Trạng Thái" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btnChon" runat="server" CausesValidation="False" CommandName="ChonSP" Text="Chọn" CommandArgument='<%# Eval("MaSP") %>' />
                        <asp:Button ID="btnXoa" runat="server" CausesValidation="False" CommandName="XoaSP" Text="Xóa" CommandArgument='<%# Eval("MaSP") %>' OnClientClick="return comfirm('Bạn có chắc muốn xóa không?');"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
