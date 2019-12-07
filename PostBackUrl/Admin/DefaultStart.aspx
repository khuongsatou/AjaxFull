<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="DefaultStart.aspx.cs" Inherits="PostBackUrl.Admin.DefaultStart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentPage" runat="server">
    <h1>Start</h1>
    <asp:Button ID="Button1" runat="server" Text="Danh Sách" PostBackUrl="~/Admin/DefaultDS.aspx" />
</asp:Content>
