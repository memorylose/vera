<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UM.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 350px; height: 200px; margin: 0 auto; padding-left: 20px; margin-top:20px;">
            <div style="height: 30px; font-weight: bold; text-align:center; font-size: 20px; margin-bottom: 20px;">
                User Login
            </div>
            <div style="height: 40px;">
                <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">User Name:</div>
                <div style="float: left; margin-left: 10px; height: 30px;">
                    <input type="text" style="height: 25px; width: 200px; border: 1px solid #DDDDDD; padding-left: 5px;" id="txtUsername" runat="server" />
                </div>
            </div>
            <div style="height: 40px;">
                <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Password:</div>
                <div style="float: left; margin-left: 10px; height: 30px;">
                    <input type="password" style="height: 25px; width: 200px; border: 1px solid #DDDDDD; padding-left: 5px;" id="txtPassword" runat="server" />
                </div>
            </div>
            <div style="height: 40px; float:right; margin-right:43px;">
                <asp:Button ID="Button1" runat="server" Text="登录" Width="70px" Height="25px" OnClick="Button1_Click" />
            </div>
        </div>
    </form>
</body>
</html>
