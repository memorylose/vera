﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftPage.ascx.cs" Inherits="UM.UI.UserControl.LeftPage" %>

<div class="col-md-3 bt-padding">
    <div class="l-personal-name">个人信息</div>
    <div class="l-personal-content">
        <img src="/images/people.jpg" class="l-personal-img" />
    </div>
    <div class="l-personal-detail">
        <div class="row bt-margin">
            <div class="l-detail-name">姓名：</div>
            <div class="l-detail-name">卡西梵</div>
        </div>
        <div class="row bt-margin">
            <div class="l-detail-name">性别：</div>
            <div class="l-detail-name">女</div>
        </div>
        <div class="row bt-margin">
            <div class="l-detail-name">职业：</div>
            <div class="l-detail-name">失业</div>
        </div>
        <div class="row bt-margin">
            <div class="l-detail-name">领域：</div>
            <div class="l-detail-name">.NET, SQL, BI</div>
        </div>
    </div>
    <div class="l-personal-name">文章分类</div>
    <div class="l-personal-detail">
        <div class="row bt-margin">
            <div class="l-cate-name"><a href="">心情随笔</a></div>
            <div class="l-cate-name-d">(10)</div>
        </div>
        <div class="row bt-margin">
            <div class="l-cate-name"><a href="">C#</a></div>
            <div class="l-cate-name-d">(28)</div>
        </div>
        <div class="row bt-margin">
            <div class="l-cate-name"><a href="">SQL SERVER</a></div>
            <div class="l-cate-name-d">(8)</div>
        </div>
        <div class="row bt-margin">
            <div class="l-cate-name"><a href="">BI</a></div>
            <div class="l-cate-name-d">(68)</div>
        </div>
    </div>
    <div class="l-personal-name">文章存档</div>
    <div class="l-personal-detail">
        <div class="row bt-margin">
            <div class="l-cate-name"><a href="">2016年01月</a></div>
            <div class="l-cate-name-d">(10)</div>
        </div>
        <div class="row bt-margin">
            <div class="l-cate-name"><a href="">2016年07月</a></div>
            <div class="l-cate-name-d">(28)</div>
        </div>
        <div class="row bt-margin">
            <div class="l-cate-name"><a href="">2016年08月</a></div>
            <div class="l-cate-name-d">(8)</div>
        </div>
        <div class="row bt-margin">
            <div class="l-cate-name"><a href="">2016年12月</a></div>
            <div class="l-cate-name-d">(68)</div>
        </div>
    </div>
    <div class="l-personal-name">阅读排行</div>
    <div class="l-personal-detail">
        <%=RankListhtml %>
    </div>
</div>












<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
