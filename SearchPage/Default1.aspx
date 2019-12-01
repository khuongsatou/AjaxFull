<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="SearchPage.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-group">
                <label for="search">Search</label>
                <asp:TextBox runat="server" class="form-control" ID="txtSearch" placeholder="Search..." />

            </div>
            <asp:Button CssClass="btn btn-primary mb-2" ID="btnSearch" runat="server" Text="Tìm" OnClick="btnSearch_Click" />
            <asp:Label ID="lblKetQua" runat="server" Text="Tìm được: "></asp:Label>
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">First</th>
                        <th scope="col">Last</th>
                        <th scope="col">Handle</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th scope="row"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "detail.aspx?id="+Eval("id") %>'>HyperLink</asp:HyperLink></th>

                                <td><%# Eval("name") %></td>
                                <td><%# Eval("img") %></td>
                                <td><%# Eval("stt") %></td>
                                <td><%# Eval("giasp") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <div>
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        
                        <a href='?page=<%#Eval("index") %><%if (Request["key"] != null) Response.Write("&key=" + Request["key"]); %>'>
                            <%#Eval("index") %>

                        </a>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
           
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:demoConnectionString %>" SelectCommand="SELECT * FROM [SanPham]"></asp:SqlDataSource>
        </div>
        <script src="js/jquery-slim.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
    </form>
</body>
</html>
