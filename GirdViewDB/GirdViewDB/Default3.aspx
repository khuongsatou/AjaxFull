<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default3.aspx.cs" Inherits="GirdViewDB.Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="MaSP" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" ShowEditButton="True" />


                    <asp:BoundField DataField="MaSP" HeaderText="MaSP" InsertVisible="False" ReadOnly="True" SortExpression="MaSP" />
                    <asp:BoundField DataField="Ten" HeaderText="Ten" SortExpression="Ten" />
                    <asp:BoundField DataField="GhiChu" HeaderText="GhiChu" SortExpression="GhiChu" />
                    <asp:BoundField DataField="Hinh" HeaderText="Hinh" SortExpression="Hinh" />
                    <asp:BoundField DataField="Gia" HeaderText="Gia" SortExpression="Gia" />
                    <asp:BoundField DataField="MaLoai" HeaderText="MaLoai" SortExpression="MaLoai" />
                    <asp:BoundField DataField="NhanVien" HeaderText="NhanVien" SortExpression="NhanVien" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLSPConnectionString %>" SelectCommand="SELECT * FROM [SanPham]" DeleteCommand="DELETE FROM [SanPham] WHERE [MaSP] = @MaSP" InsertCommand="INSERT INTO [SanPham] ([Ten], [GhiChu], [Hinh], [Gia], [MaLoai], [NhanVien]) VALUES (@Ten, @GhiChu, @Hinh, @Gia, @MaLoai, @NhanVien)" UpdateCommand="UPDATE [SanPham] SET [Ten] = @Ten, [GhiChu] = @GhiChu, [Hinh] = @Hinh, [Gia] = @Gia, [MaLoai] = @MaLoai, [NhanVien] = @NhanVien WHERE [MaSP] = @MaSP">
                <DeleteParameters>
                    <asp:Parameter Name="MaSP" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Ten" Type="String" />
                    <asp:Parameter Name="GhiChu" Type="String" />
                    <asp:Parameter Name="Hinh" Type="String" />
                    <asp:Parameter Name="Gia" Type="String" />
                    <asp:Parameter Name="MaLoai" Type="Int32" />
                    <asp:Parameter Name="NhanVien" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Ten" Type="String" />
                    <asp:Parameter Name="GhiChu" Type="String" />
                    <asp:Parameter Name="Hinh" Type="String" />
                    <asp:Parameter Name="Gia" Type="String" />
                    <asp:Parameter Name="MaLoai" Type="Int32" />
                    <asp:Parameter Name="NhanVien" Type="String" />
                    <asp:Parameter Name="MaSP" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
