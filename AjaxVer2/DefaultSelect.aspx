<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultSelect.aspx.cs" Inherits="AjaxVer2.DefaultSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div id="result">
                đây là text
            </div>
            <%--<asp:TextBox ValidationGroup="i"  ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ValidationGroup="i" ID="btnInsert" runat="server" Text="Insert" OnClientClick="InsertAll();return false;" />
            <br />
            <asp:Button ValidationGroup="s" ID="btnSelect" runat="server" Text="Select" OnClientClick="SelectALL();return false;" />--%>
            <br />
             <asp:TextBox ValidationGroup="ser"  ID="txtSearch" runat="server"></asp:TextBox><br />
             <asp:Button ValidationGroup="ser" ID="btnSearch" runat="server" Text="Search" OnClientClick="SearchAll();return false;" />
        </div>
        <script src="js/jquery-3.4.1.min.js"></script>
        <script>
            function InsertAll() {
                var name = $('#txtName').val();
                alert("123" + name);
                var param = "'name':'"+name+"'";
                $.ajax({
                    type: 'post',
                    url: 'DefaultSelect.aspx/insert',
                    data: "{" + param+"}",
                    contentType: 'application/json;charset=utf-8',
                    datatype: 'json',
                    success: function (response) {
                        alert(response.d);
                    },
                    error: function (err) {
                        alert(err.d);
                    }
                });
            }
            function SelectALL() {

                $.ajax({
                    type: 'post',
                    url: 'DefaultSelect.aspx/select',
                    data: "{}",
                    contentType: 'application/json;charset=utf-8',
                    datatype: 'json',
                    success: function (response) {
                        var data = response.d;
                        var table = "<table style='width: 50%;'>";
                        table += "<th>Mã Loại</th>"
                        table += "<th>Tên Loại</th>"
                        for (i = 0; i < data.length; i++) {
                            table += "<tr>"
                            table += "<td>"
                            table += data[i].MaL;
                            table += "</td>"
                            table += "<td>"
                            table += data[i].TenLoai;
                            table += "</td>"
                            table += "</tr>"
                        }
                        table += " </table>";
                        $('#result').html(table);
                    },
                    error: function (err) {
                        alert(err.d);
                    }
                });

            }
            function SearchAll() {
                var name = $('#txtSearch').val();
                alert("123:" + name);
                var param = "'name':'" + name + "'";
                $.ajax({
                    type: 'post',
                    url: 'DefaultSelect.aspx/search',
                    data: "{" + param + "}",
                    contentType: 'application/json;charset=utf-8',
                    datatype: 'json',
                    success: function (response) {
                        var data = response.d;
                        var table = "<table style='width: 50%;'>";
                        table += "<th>Mã Loại</th>"
                        table += "<th>Tên Loại</th>"
                        for (i = 0; i < data.length; i++) {
                            table += "<tr>"
                            table += "<td>"
                            table += data[i].MaL;
                            table += "</td>"
                            table += "<td>"
                            table += data[i].TenLoai;
                            table += "</td>"
                            table += "</tr>"
                        }
                        table += " </table>";
                        $('#result').html(table);
                    },
                    error: function (err) {
                        alert(err.d);
                    }
                });
            }

            

        </script>
    </form>
</body>
</html>
