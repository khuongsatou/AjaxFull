<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AjaxLoader.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-3.4.1.min.js"></script>
    <script>
        function requestWithData(userid) {
            var txtKey = $("#txtKey").val();
            alert(txtKey);
            $.ajax({
                url: 'WebForm1.aspx/getData',
                type: "POST",
                data: "{'userid':'" + 3 + "'}",
                contentType: "application/json;charset=utf-8",
                success: function (data) {
                    alert(data.d);
                },
                error: function (data) {
                    console.log(data);
                }
            });
        }

        function getJsonData(userid) {
            var txtKey = $("#txtKey").val();
            alert(txtKey);
            $.ajax({
                url: 'WebForm1.aspx/getDataTableJson',
                type: "POST",
                data: "{'userid':'" + 3 + "'}",
                contentType: "application/json;charset=utf-8",
                success: function (data) {
                    alert(data.d);
                    var lst_json = JSON.parse(data.d);
                    console.log(lst_json.length);

                    $('#lst>tbody').html('');
                    for (var i = 0; i < lst_json.length; i++) {
                        var tr = document.createElement("tr");
                        tr.innerHTML = '<td>' + lst_json[i].Name + '</td><td>' + lst_json[i].Des + '</td>';
                        $('#lst>tbody').append(tr);
                    }
                },
                error: function (data) {
                    console.log(data);
                }
            });
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="txtKey" type="text" />
            <input id="btn" type="button" onclick="requestWithData();" value="Lấy dữ liệu " />
            <input id="btn1" type="button" onclick="getJsonData();" value="Lấy dữ liệu Json " />

        </div>
        <table id="lst" style="width: 100%;">
           <thead>
               <tr>
                   <th>
                       Name
                   </th>
                    <th>
                       Des
                   </th>
               </tr>
           </thead>
            <tbody>
                
            </tbody>

        </table>


    </form>
</body>
</html>
