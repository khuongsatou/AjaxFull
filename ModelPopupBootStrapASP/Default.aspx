<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ModelPopupBootStrapASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <asp:Button ID="Button1" CssClass="btn btn-primary btn-sm" data-target="#loginModal" data-toggle="modal" runat="server" Text="Show" OnClientClick="return false;" />
                    <div class="modal" id="loginModal" tabindex="-1" data-backdrop="static">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h4 class="modal-title">Login</h4>
                                    <button class="close" data-dismiss="modal">&times;</button>
                                </div>
                                <div class="modal-body">
                                    <div>
                                        <div class="form-group">
                                            <label for="inputUserName">UserName</label>
                                            <input class="form-control" type="text" id="inputUserName" placeholder="username" />
                                        </div>
                                        <div class="form-group">
                                            <label for="inputPassword">Password</label>
                                            <input class="form-control" type="text" id="inputPassword" placeholder="password" />
                                        </div>
                                    </div>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button CssClass="btn btn-primary" ID="Button2" runat="server" Text="Login" />
                                    <asp:Button CssClass="btn btn-primary" ID="Button3" runat="server" data-dismiss="modal" Text="Close" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="js/jquery-slim.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script>
        $(this).ready(function () {
            $('#button').click(function () {
                alert("div");
            });
        });
    </script>
</body>
</html>
