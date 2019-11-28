<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="GridView.DataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="MaL" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand" Width="430px">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("MaL") %>'></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" CommandName="c" Text="Cập Nhật" />
                    <asp:Button ID="Button4" runat="server" CommandName="h" Text="Hủy" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="Button5" runat="server" CommandName="t" Text="Thêm" />
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="MaLLabel" runat="server" Text='<%# Eval("MaL") %>' />
                    <asp:Label ID="TenLoaiLabel" runat="server" Text='<%# Eval("TenLoai") %>' />
                    &nbsp;
                    <asp:Button ID="Button1" runat="server" CommandName="x" Text="Xóa" />
                    <asp:Button ID="Button2" runat="server" CommandName="s" Text="Sửa" />
                    <br />
<br />
                </ItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLSPConnectionString %>" DeleteCommand="DELETE FROM [LoaiSP] WHERE [MaL] = @MaL" InsertCommand="INSERT INTO [LoaiSP] ([TenLoai]) VALUES (@TenLoai)" SelectCommand="SELECT * FROM [LoaiSP]" UpdateCommand="UPDATE [LoaiSP] SET [TenLoai] = @TenLoai WHERE [MaL] = @MaL">
                <DeleteParameters>
                    <asp:Parameter Name="MaL" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="TenLoai" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="TenLoai" Type="String" />
                    <asp:Parameter Name="MaL" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
