<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UM.UI.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Register</title>
    <link href="styles/bootstrap.min.css" rel="stylesheet" />
    <link href="styles/flat-ui.css" rel="stylesheet" />
    <link href="styles/demo.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="margin-top:100px;">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                    <div class="form-group">
                        <input type="text" class="form-control login-field" value="" placeholder="Enter your name" id="txtUsername" runat="server" />
                    </div>
                    <div class="form-group">
                        <input type="password" class="form-control login-field" value="" placeholder="Password" id="txtPassword" runat="server" />
                    </div>
                    <div class="form-group">
                        <input type="text" class="form-control login-field" value="" placeholder="Email" id="txtMail" runat="server" />
                    </div>               
                    <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg btn-block" runat="server" Text="Log in" OnClick="Button1_Click1" />
                    <a class="login-link" href="#">Lost your password?</a>
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </form>
</body>
</html>
