﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Top.ascx.cs" Inherits="UM.UI.UserControl.Top" %>
<div class="container-fluid" style="margin-top: 20px;">
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8">
            <div class="row">
                <div class="col-md-3">
                    <div class="top-left"><%=Pageheadhtml%></div>
                </div>
                <div class="col-md-9">
                    <div class="row">
                        <div class="col-md-1" style="padding: 0;">
                            <div class="top-menu"><%--<%=HomePagehtml%>--%><a href="/Article/Article.aspx">首页</a></div>
                        </div>
                        <div class="col-md-1" style="padding: 0;">
                            <div class="top-menu"><%--<%=MyArticlehtml%>--%><a href="/Article/Article.aspx">我的</a></div>
                        </div>
                        <div class="col-md-1" style="padding: 0;">
                            <div class="top-menu"><%--<%=Popularhtml%>--%><a href="/Article/Article.aspx">热文</a></div>
                        </div>
                        <div class="col-md-1" style="padding: 0;">
                            <div class="top-menu"><%--<%=Abouttml%>--%><a href="/Article/Article.aspx">关于</a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-2"></div>
    </div>
</div>