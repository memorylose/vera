<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="UM.UI.Article.Article" %>

<%@ Register Src="~/UserControl/Top.ascx" TagPrefix="uc1" TagName="Top" %>
<%@ Register Src="~/UserControl/Todo.ascx" TagPrefix="uc1" TagName="Todo" %>
<%@ Register Src="~/UserControl/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>



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
        <uc1:Top runat="server" ID="Top" />
        <div class="container-fluid" style="margin-top: 20px;">
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8" style="padding: 0;">
                    <div class="content-main">
                        <div class="row">
                            <div class="col-md-8">
                                <%=Articleshtml %>
                                <%--<div class="row">
                                    <div class="col-md-12 content-title"><a href="">你的不叫努力,叫重复劳动,明白么!</a></div>
                                    <div class="col-md-12 content-date"><span>2016/07/12 21:00</span><span>-</span><span>心情散文</span></div>
                                    <div class="col-md-12 content-t">
                                        记得原来上学的时候，有一个同桌，别人学习的时间他也在学，别人玩的时间他也在玩，但是成绩一直不是很好。他总说自己脑子慢。有一次考完试，我看他在写什么东西，我过去看了一眼，发现他把错的题，一字不差的抄到了本子上。
我问他：“为什么每道题都要抄呢？试卷上不是有么？”
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12 content-title"><a href="">你的不叫努力,叫重复劳动,明白么!</a></div>
                                    <div class="col-md-12 content-date"><span>2016/07/12 21:00</span><span>-</span><span>心情散文</span></div>
                                    <div class="col-md-12 content-t">
                                        记得原来上学的时候，有一个同桌，别人学习的时间他也在学，别人玩的时间他也在玩，但是成绩一直不是很好。他总说自己脑子慢。有一次考完试，我看他在写什么东西，我过去看了一眼，发现他把错的题，一字不差的抄到了本子上。
我问他：“为什么每道题都要抄呢？试卷上不是有么？”
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12 content-title"><a href="">你的不叫努力,叫重复劳动,明白么!</a></div>
                                    <div class="col-md-12 content-date"><span>2016/07/12 21:00</span><span>-</span><span>心情散文</span></div>
                                    <div class="col-md-12 content-t">
                                        记得原来上学的时候，有一个同桌，别人学习的时间他也在学，别人玩的时间他也在玩，但是成绩一直不是很好。他总说自己脑子慢。有一次考完试，我看他在写什么东西，我过去看了一眼，发现他把错的题，一字不差的抄到了本子上。
我问他：“为什么每道题都要抄呢？试卷上不是有么？”
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12 content-title"><a href="">你的不叫努力,叫重复劳动,明白么!</a></div>
                                    <div class="col-md-12 content-date"><span>2016/07/12 21:00</span><span>-</span><span>心情散文</span></div>
                                    <div class="col-md-12 content-t">
                                        记得原来上学的时候，有一个同桌，别人学习的时间他也在学，别人玩的时间他也在玩，但是成绩一直不是很好。他总说自己脑子慢。有一次考完试，我看他在写什么东西，我过去看了一眼，发现他把错的题，一字不差的抄到了本子上。
我问他：“为什么每道题都要抄呢？试卷上不是有么？”
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12 content-title"><a href="">你的不叫努力,叫重复劳动,明白么!</a></div>
                                    <div class="col-md-12 content-date"><span>2016/07/12 21:00</span><span>-</span><span>心情散文</span></div>
                                    <div class="col-md-12 content-t">
                                        记得原来上学的时候，有一个同桌，别人学习的时间他也在学
                                    </div>
                                </div>--%>
                            </div>
                            <uc1:Todo runat="server" ID="Todo" />
                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
            <%--Begin footer--%>
            <uc1:Footer runat="server" id="Footer" />
        </div>
    </form>
</body>
</html>
