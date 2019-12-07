<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLLoaiSanPham.aspx.cs" Inherits="GUI.QLSanPham" %>

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
                <td>Mã loại sản phẩm</td>
                <td>
                    <asp:TextBox ID="txtMaLoaiSP" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tên loại sản phẩm</td>
                <td>
                    <asp:TextBox ID="txtTenLoaiSP" runat="server"></asp:TextBox></td>
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
        <asp:GridView ID="grvDSLoaiSP" runat="server" AutoGenerateColumns="False" OnRowCommand="grvDSLoaiSP_RowCommand">
            <Columns>
                <asp:BoundField DataField="MaLoaiSP" HeaderText="Mã loại sản phẩm" />
                <asp:BoundField DataField="TenLoaiSP" HeaderText="Tên loại sản phẩm" />
                <asp:CheckBoxField DataField="TrangThai" HeaderText="Trạng Thái" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btnChon" runat="server" CausesValidation="False" CommandName="ChonLoaiSP" Text="Chọn" CommandArgument='<%# Eval("MaLoaiSP") %>' />
                        <asp:Button ID="btnXoa" runat="server" CausesValidation="False" CommandName="XoaLoaiSP" Text="Xóa" CommandArgument='<%# Eval("MaLoaiSP") %>'  OnClientClick="return confirm('Bạn có chắc chắn muốn xóa?');" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>


        </asp:GridView>

    </div>
    </form>
</body>
</html>
