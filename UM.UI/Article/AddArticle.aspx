﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="UM.UI.Article.AddArticle" ValidateRequest="false" %>

<%@ Register Src="~/UserControl/Top.ascx" TagPrefix="uc1" TagName="Top" %>
<%@ Register Src="~/UserControl/Todo.ascx" TagPrefix="uc1" TagName="Todo" %>
<%@ Register Src="~/UserControl/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Article</title>
    <link href="/styles/bootstrap.min.css" rel="stylesheet" />
    <link href="/styles/index.css" rel="stylesheet" />
    <script src="/scripts/jquery-3.0.0.min.js"></script>

    <%--KindEditor--%>
    <link href="/styles/kindeditor.css" rel="stylesheet" />
    <link href="/styles/simple.css" rel="stylesheet" />

    <script type="text/javascript" src="/scripts/kindeditor-min.js"></script>
    <script type="text/javascript" src="/scripts/zh_CN.js"></script>
    <script type="text/javascript" src="/scripts/prettify.js"></script>


    <script>
        KindEditor.ready(function (K) {
            K.create('#content2', {
                themeType: 'simple',
                items: [
                        'source', '|', 'code', 'paste',
                        'plainpaste', 'wordpaste', '|', 'justifyleft', 'justifycenter', 'justifyright',
                        'justifyfull',
                        'formatblock', 'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold',
                        'italic', 'underline', 'strikethrough', 'lineheight', 'removeformat', '|', 'emoticons'
                ],
                pluginsPath: "/styles/plugins/"
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:Top runat="server" ID="Top" />
        <div class="container-fluid" style="margin-top: 20px;">
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8" style="padding: 0;">
                    <div class="content-main">
                        <div class="row">
                            <div class="col-md-8">

                                <div style="height: 40px; margin-top: 30px;" class="title-div">
                                    <input type="text" class="title-input" value="" placeholder="标题" id="txtTitle" runat="server" />
                                </div>
                                <div style="height: 100px;" class="title-div">
                                    <textarea class="title-input" runat="server" id="txtSummary" style="height: 100px;" placeholder="摘要（可不填）"></textarea>
                                </div>
                                <div style="height: 400px;" class="title-div">
                                    <textarea name="content" id="content2" style="width: 100%; height: 400px;"></textarea>
                                </div>
                                <div style="height: 40px;" class="title-div">

                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dp"></asp:DropDownList>
                                </div>
                                <div style="height: 40px;" class="title-div">
                                    <asp:Button ID="Button1" runat="server" Text="提交" CssClass="btn btn-danger create-btn" OnClick="Button1_Click" />
                                </div>
                            </div>

                            <div class="reg_err">
                                <%=AddErrorMessageshtml%>
                            </div>

                            <uc1:Todo runat="server" ID="Todo" />
                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
            <%--Begin footer--%>
            <uc1:Footer runat="server" ID="Footer" />
        </div>
    </form>
</body>
</html>
