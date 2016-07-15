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

        
        <div class="container-fluid" style="margin-top: 20px;">
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8" style="padding: 0;">
                    <div class="content-main">
                        <div class="row">
                            <div class="col-md-8">
                                <%=Articleshtml%>
                                <%--<div class="row">
                                    <div class="col-md-12 content-title"><a href="">Home Page</a></div>
                                    <div class="col-md-12 content-date"><span>2016/7/5 20:23:39</span><span>-</span><span>杂文</span></div>
                                    <div class="col-md-12 content-t">
                                        This is Add Article page
                                    </div>
                                </div>--%>
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
                            <%--<div class="col-md-4">TODO</div>--%>
                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
        </div>
    </form>
</body>
</html>
