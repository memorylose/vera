<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="UM.UI.Article.Article" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Article Name</title>
    <link href="/styles/bootstrap.min.css" rel="stylesheet" />
    <link href="/styles/index.css" rel="stylesheet" />
    <script src="/scripts/jquery-3.0.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <%--      <div style="width: 350px; height: 200px; margin: 0 auto; padding-left: 20px; margin-top: 20px;">
            <%=Articlehtml%>
        </div>--%>
        <div class="container-fluid" style="margin-top: 20px;">
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8">
                    <div class="row">
                        <div class="col-md-3">
                            <div class="top-left">Vera`s Blog</div>
                        </div>
                        <div class="col-md-9">
                            <div class="row">
                                <div class="col-md-1" style="padding: 0;">
                                    <div class="top-menu"><a href="/Article/Article.aspx">首页</a></div>
                                </div>
                                <div class="col-md-1" style="padding: 0;">
                                    <div class="top-menu"><a href="/Article/Article.aspx">我的</a></div>
                                </div>
                                <div class="col-md-1" style="padding: 0;">
                                    <div class="top-menu"><a href="/Article/Article.aspx">热文</a></div>
                                </div>
                                <div class="col-md-1" style="padding: 0;">
                                    <div class="top-menu"><a href="/Article/Article.aspx">关于</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
        </div>

        <div class="container-fluid" style="margin-top: 20px;">
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8">
                    <div class="content-main">

                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
        </div>
    </form>
</body>
</html>
