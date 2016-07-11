<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UM.UI.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Register</title>
    <link href="styles/bootstrap.min.css" rel="stylesheet" />
    <link href="styles/flat-ui.css" rel="stylesheet" />
    <link href="styles/demo.css" rel="stylesheet" />
    <link href="styles/index.css" rel="stylesheet" />
    <script src="scripts/jquery-3.0.0.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <script>
        $(function () { $("[data-toggle='tooltip']").tooltip(); });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid" style="margin-top: 100px;">
            <div class="row">
                <div class="col-lg-5"></div>
                <div class="col-lg-2"  style="padding:30px; background-color:white; border:1px solid #DDDDDD">
                    <div class="login-form">
                        <div class="form-group" data-toggle="tooltip" data-placement="left"
                            title="6-20位字母或数字">
                            <input type="text" class="form-control" value="" placeholder="用户名" id="txtUsername" runat="server" />
                            <label class="login-field-icon fui-user" for="login-name"></label>
                        </div>

                        <div class="form-group" data-toggle="tooltip" data-placement="left"
                            title="6-16位字母加数字">
                            <input type="password" class="form-control" value="" placeholder="密码" id="txtPassword" runat="server" />
                            <label class="login-field-icon fui-lock" for="login-pass"></label>
                        </div>
                        <div class="form-group" data-toggle="tooltip" data-placement="left"
                            title="再次输入密码">
                            <input type="password" class="form-control" value="" placeholder="密码" id="txtConfirmPassword" runat="server" />
                            <label class="login-field-icon fui-lock" for="login-pass"></label>
                        </div>
                        <div class="form-group" data-toggle="tooltip" data-placement="left"
                            title="用来找回密码">
                            <input type="text" class="form-control" value="" placeholder="邮箱" id="txtMail" runat="server" />
                            <label class="login-field-icon fui-mail" for="login-pass"></label>
                        </div>
                        <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg btn-block" runat="server" Text="注册" OnClick="Button1_Click1" />
                    </div>
                    <a class="login-link" href="/Login.aspx">已有账号？</a>
                </div>
                <div class="col-lg-5"></div>
            </div>
            <div class="row">
                <div class="reg_err">
                    <%=RegisterErrorMessageshtml%>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
