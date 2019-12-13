<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="OnPaging.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                STT:
                <asp:Label ID="STTLabel" runat="server" Text='<%# Eval("STT") %>' />
                <br />
                TenSP:
                <asp:Label ID="TenSPLabel" runat="server" Text='<%# Eval("TenSP") %>' />
                <br />
                GiaSP:
                <asp:Label ID="GiaSPLabel" runat="server" Text='<%# Eval("GiaSP") %>' />
                <br />
                MoTa:
                <asp:Label ID="MoTaLabel" runat="server" Text='<%# Eval("MoTa") %>' />
                <br />
                HinhAnh:
                <asp:Label ID="HinhAnhLabel" runat="server" Text='<%# Eval("HinhAnh") %>' />
                <br />
<br />
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <a href="?page=<%#Eval("index") %>"><%#Eval("index") %>"</a>
            </ItemTemplate>
        </asp:Repeater>

      
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbConnectionString %>" SelectCommand="SELECT * FROM [tbSanPham] WHERE (([TenSP] LIKE '%' + @TenSP + '%') OR ([MoTa] LIKE '%' + @MoTa + '%'))">
            <SelectParameters>
                <asp:Parameter Name="TenSP" Type="String" />
                <asp:Parameter Name="MoTa" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
