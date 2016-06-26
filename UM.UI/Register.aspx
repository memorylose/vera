<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UM.UI.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 30px; font-weight: bold; font-size: 20px; margin-bottom: 20px;">
            User Register
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
        <div style="height: 40px;">
            <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Email:</div>
            <div style="float: left; margin-left: 10px; height: 30px;">
                <input type="text" style="height: 25px; width: 200px; border: 1px solid #DDDDDD; padding-left: 5px;" id="txtMail" runat="server" />
            </div>
        </div>
        <div style="height: 40px;">
            <asp:Button ID="Button1" runat="server" Text="注册" Width="70px" Height="25px" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
