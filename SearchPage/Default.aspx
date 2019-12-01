<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SearchPage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <asp:FileUpload ID="ful_img" runat="server" />
            <asp:DropDownList ID="ddl_stt" runat="server"></asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Width="211px">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" InsertVisible="False" ReadOnly="True" />
                    <asp:TemplateField HeaderText="name" SortExpression="name">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Bạn chưa nhập"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("id", "abc.aspx?id={0}") %>' Text='<%# Eval("id") %>'></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("img") %>'></asp:Label>
                            <br />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="42px" ImageUrl='<%# Eval("img", "~/img/{0}") %>' Width="187px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="stt" HeaderText="stt" SortExpression="stt" />
                    <asp:CommandField ShowEditButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:demoConnectionString %>" SelectCommand="SELECT * FROM [SanPham]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
