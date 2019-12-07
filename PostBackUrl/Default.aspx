<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PostBackUrl.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPage" runat="server">
       <h1>Send</h1>
    <asp:TextBox ID="txtNhap" runat="server"></asp:TextBox>
    <asp:Button ID="btnChuyen" runat="server" Text="Button" PostBackUrl="~/Default2.aspx" />

</asp:Content>
