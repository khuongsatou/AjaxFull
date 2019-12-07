<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="DefaultDS.aspx.cs" Inherits="PostBackUrl.Admin.DefaultDS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPage" runat="server">
    <h1>DS</h1>
    <asp:Button ID="Button1" runat="server" Text="Thêm" PostBackUrl="~/Admin/DefaultThem.aspx" />
    <asp:Button ID="Button2" runat="server" Text="Start" PostBackUrl="~/Admin/DefaultStart.aspx" />
</asp:Content>
