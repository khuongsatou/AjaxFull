<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GirdViewDB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 464px;
        }
        .auto-style2 {
            width: 63px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style2">Tên</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtTen" runat="server" Width="401px"></asp:TextBox>

                </td>

            </tr>
            <tr>
                <td class="auto-style2">Giá Từ</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtGiaTu" runat="server" Width="161px"></asp:TextBox>
                    Đến<asp:TextBox ID="txtGiaDen" runat="server" Width="212px"></asp:TextBox>
                </td>

               

            </tr>
            <tr>
                <td class="auto-style2">Loại</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="278px">
                    </asp:DropDownList>
                </td>

            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1">
                    <asp:Button ID="btnTim" runat="server" Text="Tìm"  OnClick="BtnTim_Click"/>
                    <asp:Button ID="btnLamMoi" runat="server" Text="Làm Mới" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
