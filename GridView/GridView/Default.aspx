<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GridView.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>Tên (*)</td>
                    <td>
                        <asp:TextBox ID="txtTen" runat="server"></asp:TextBox>

                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>Giá Bán(*)</td>
                    <td>
                        <asp:TextBox ID="txtGiaBan" runat="server"></asp:TextBox>

                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>Hình</td>
                    <td>
                        <asp:FileUpload ID="fuBrowse" runat="server" OnUnload="fuBrowse_Unload"  />

                    </td>
                    <td>
                        <asp:Image ID="Image2" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td>Ghi Chú</td>
                    <td>
                        <asp:TextBox ID="txtGhiChu" runat="server" TextMode="MultiLine"></asp:TextBox>

                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>Loại</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="Toán">

                            </asp:ListItem>
                        </asp:DropDownList>

                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

                    </td>
                </tr>
            </table>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="MaSP" DataSourceID="SqlDataSource1" Width="955px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>

                    <asp:CommandField ShowSelectButton="True" />

                    <asp:BoundField DataField="MaSP" HeaderText="MaSP" SortExpression="MaSP" InsertVisible="False" ReadOnly="True" HtmlEncode="False" />
                    <asp:BoundField DataField="Ten" HeaderText="Ten" SortExpression="Ten" HtmlEncode="False" />


                    <asp:BoundField DataField="Gia" HeaderText="Gia" SortExpression="Gia" DataFormatString="{0:0,0}" HtmlEncode="False" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="33px" ImageUrl='<%# Eval("Hinh", "~/img/{0}") %>' Width="207px" />
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:BoundField DataField="GhiChu" HeaderText="GhiChu" SortExpression="GhiChu" HtmlEncode="False" />
                    <asp:BoundField DataField="TenLoai" HeaderText="TenLoai" SortExpression="TenLoai" />


                </Columns>

                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />

            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLSPConnectionString %>" SelectCommand="SELECT Hinh, Gia, LoaiSP.TenLoai, SanPham.MaSP, Ten, GhiChu FROM SanPham CROSS JOIN LoaiSP"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
