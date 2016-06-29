<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="UM.UI.Article.AddArticle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Article</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 30px; font-weight: bold; font-size: 20px; margin-bottom: 20px;">
            Add Article
        </div>
        <div style="height: 40px;">
            <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Title:</div>
            <div style="float: left; margin-left: 10px; height: 30px;">
                <input type="text" style="height: 25px; width: 200px; border: 1px solid #DDDDDD; padding-left: 5px;" id="txtTitle" runat="server" />
            </div>
        </div>
        <div style="height: 320px;">
            <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Contents:</div>
            <div style="float: left; margin-left: 10px; height: 30px;">
                <textarea cols="60" rows="20" style="border:1px solid #DDDDDD" id="txtContent" runat="server"></textarea>
            </div>
        </div>
        <div style="height: 40px;">
            <asp:Button ID="Button1" runat="server" Text="Create" Width="70px" Height="25px" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
