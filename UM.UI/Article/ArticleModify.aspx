<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArticleModify.aspx.cs" Inherits="UM.UI.Article.ArticleModify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Article Title</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 40px;">
            <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Title:</div>
            <div style="float: left; margin-left: 10px; height: 30px;">
                <input type="text" style="height: 25px; width: 200px; border: 1px solid #DDDDDD; padding-left: 5px;" id="txtTitle" runat="server" />
            </div>
        </div>
        <%--<%=Titlehtml%>--%>
        <div style="height: 320px;">
            <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Contents:</div>
            <div style="float: left; margin-left: 10px; height: 30px;">
                <textarea cols="60" rows="20" style="border: 1px solid #DDDDDD" id="txtContent" runat="server"></textarea>
            </div>
        </div>
        <%--<%=Contenthtml%>--%>
        <div style="height: 320px;">
            <div style="float: left; font-size: 13px; height: 30px; line-height: 30px; font-weight: bold; width: 90px;">Type:</div>
            <div style="float: left; margin-left: 10px; height: 30px;">
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div style="height: 40px;">
            <asp:Button ID="Button1" runat="server" Text="Update" Width="70px" Height="25px" OnClick="Button1_Click" />
        </div>

        <div>
            <%--<%=Timehtml%>--%>
        </div>
        <%--<asp:DropDownList ID="DropDownList2" runat="server"  >

<asp:ListItem Value="1">a</asp:ListItem>

<asp:ListItem Value="2">b</asp:ListItem>

<asp:ListItem Value="3">c</asp:ListItem>

<asp:ListItem Value="4">d</asp:ListItem>

</asp:DropDownList>--%>

    </form>
</body>
</html>
