<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="GirdViewDB.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server" DataKeyField="MaL" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand">
            <ItemTemplate>
                MaL:
                <asp:Label ID="MaLLabel" runat="server" Text='<%# Eval("MaL") %>' />
                <br />
                TenLoai:
                <asp:Label ID="TenLoaiLabel" runat="server" Text='<%# Eval("TenLoai") %>' />
                <br />
                <asp:Button ID="Button1" runat="server" CommandName="x" Text='<%# Eval("MaL") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLSPConnectionString %>" DeleteCommand="DELETE FROM [LoaiSP] WHERE [MaL] = @MaL" InsertCommand="INSERT INTO [LoaiSP] ([TenLoai]) VALUES (@TenLoai)" SelectCommand="SELECT * FROM [LoaiSP]" UpdateCommand="UPDATE [LoaiSP] SET [TenLoai] = @TenLoai WHERE [MaL] = @MaL">
            <DeleteParameters>
                <asp:Parameter  Name="MaL" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="TenLoai" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TenLoai" Type="String" />
                <asp:Parameter Name="MaL" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
