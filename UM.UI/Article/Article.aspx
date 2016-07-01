<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="UM.UI.Article.Article" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 350px; height: 200px; margin: 0 auto; padding-left: 20px; margin-top: 20px;">
            <%--<div style="height: 30px; text-align: center; font-size: 20px; margin-bottom: 20px;">
                This is articles title
            </div>--%>

            <%=Articlehtml%>
        </div>
    </form>
</body>
</html>
