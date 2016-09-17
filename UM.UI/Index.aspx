<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UM.UI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vera Blog</title>
    <link href="/styles/bootstrap.min.css" rel="stylesheet" />
    <link href="/styles/NewIndex.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <div class="container">
                <div class="row">
                    <div class="col-md-2 header-col"></div>
                    <div class="col-md-8 header-col"></div>
                    <div class="col-md-2 header-col">
                        <div class="header-login"><a href="">注册</a></div>
                        <div class="header-login"><a href="">登录</a></div>
                    </div>
                </div>
            </div>

        </div>

        <div class="container">
            <div class="row header-name">
                <div class="header-name-detail">VERA</div>
            </div>
            <div class="row header-word">
                <div class="header-word-detail">
                    It is said that you will appear in the dreams of others when you fail to fall asleep.
                </div>
            </div>
        </div>

        <div class="container">
            <div class="row test" style="">
                <div class="col-md-3 test" style="height: 40px;">1</div>
                <div class="col-md-9 test">2</div>

            </div>

        </div>
    </form>
</body>
</html>
