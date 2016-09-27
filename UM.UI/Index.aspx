<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UM.UI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>薇拉生活坊</title>
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
                        <%=Pageheadhtml%>
                        <%--<div class="header-login"><a href="">注册</a></div>
                        <div class="header-login"><a href="">登录</a></div>--%>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <img src="/images/logo.png" class="header-img" />
            </div>
            <div class="row header-word">
                <div class="header-word-detail">
                    It is said that you will appear in the dreams of others when you fail to fall asleep.
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row bt-center">
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
                        <%--<div class="row bt-margin">
                            <div class="l-read-name"><a href="">WebApi - 错误处理</a></div>
                            <div class="l-read-name-d">(239)</div>
                        </div>
                        <div class="row bt-margin">
                            <div class="l-read-name"><a href="">REST-ful Service 设计标准 </a></div>
                            <div class="l-read-name-d">(218)</div>
                        </div>
                        <div class="row bt-margin">
                            <div class="l-read-name"><a href="">Entity Framework - Call S...</a></div>
                            <div class="l-read-name-d">(18)</div>
                        </div>
                        <div class="row bt-margin">
                            <div class="l-read-name"><a href="">Entity Framework Log </a></div>
                            <div class="l-read-name-d">(68)</div>
                        </div>--%>
                    </div>
                </div>
                <div class="col-md-9 r-content">
                    <div class="l-personal-name" style="margin-left: 20px;">欢迎来到我的生活坊</div>
                    <%=ArticleListhtml %>
                    <div class="r-content-d">
                        <div class="row row-marginb">
                            <div class="col-md-1 bt-padding r-time-d">
                                <div class="r-date-t">
                                    <div class="r-date-year">2016</div>
                                    <div class="r-date-month">九</div>
                                </div>
                                <div class="r-date-b">
                                    18
                                </div>
                            </div>
                            <div class="col-md-10 bt-padding">
                                <div class="r-title"><a href="">WebApi - 错误处理</a></div>
                                <div class="r-time-1"><a href="">随笔散文</a></div>
                                <div class="r-time-1"><a href="">编辑</a></div>
                                <div class="r-time-1"><a href="">删除</a></div>
                                <div style="clear: both"></div>
                                <div class="r-subject">在WebApi2中，新增了一个新的返回类型，也就是IHttpActionResult，这样Web个新的返回类个新的返回类Api一共有4个返回类型。 1. void 2. HttpResponseMessage 直接返回一个http的response message 3. IHttpActionResult 在ap</div>
                            </div>
                        </div>
                    </div>

                    <%--<div class="r-content-d">
                        <div class="row row-marginb">
                            <div class="col-md-1 bt-padding r-time-d">
                                <div class="r-date-t">
                                    <div class="r-date-year">2016</div>
                                    <div class="r-date-month">九</div>
                                </div>
                                <div class="r-date-b">
                                    18
                                </div>
                            </div>
                            <div class="col-md-10 bt-padding">
                                <div class="r-title"><a href="">WebApi - 错误处理</a></div>
                                <div class="r-time-1"><a href="">随笔散文</a></div>
                                <div class="r-time-1"><a href="">编辑</a></div>
                                <div class="r-time-1"><a href="">删除</a></div>
                                <div style="clear: both"></div>
                                <div class="r-subject">在WebApi2中，新增了一个新的返回类型，也就是IHttpActionResult，这样Web个新的返回类个新的返回类Api一共有4个返回类型。 1. void 2. HttpResponseMessage 直接返回一个http的response message 3. IHttpActionResult 在ap</div>
                            </div>
                        </div>
                    </div>

                    <div class="r-content-d">
                        <div class="row row-marginb">
                            <div class="col-md-1 bt-padding r-time-d">
                                <div class="r-date-t">
                                    <div class="r-date-year">2016</div>
                                    <div class="r-date-month">九</div>
                                </div>
                                <div class="r-date-b">
                                    18
                                </div>
                            </div>
                            <div class="col-md-10 bt-padding">
                                <div class="r-title"><a href="">WebApi - 错误处理</a></div>
                                <div class="r-time-1"><a href="">随笔散文</a></div>
                                <div class="r-time-1"><a href="">编辑</a></div>
                                <div class="r-time-1"><a href="">删除</a></div>
                                <div style="clear: both"></div>
                                <div class="r-subject">在WebApi2中，新增了一个新的返回类型，也就是IHttpActionResult，这样Web个新的返回类个新的返回类Api一共有4个返回类型。 1. void 2. HttpResponseMessage 直接返回一个http的response message 3. IHttpActionResult 在ap</div>
                            </div>
                        </div>
                    </div>

                    <div class="r-content-d">
                        <div class="row row-marginb">
                            <div class="col-md-1 bt-padding r-time-d">
                                <div class="r-date-t">
                                    <div class="r-date-year">2016</div>
                                    <div class="r-date-month">九</div>
                                </div>
                                <div class="r-date-b">
                                    18
                                </div>
                            </div>
                            <div class="col-md-10 bt-padding">
                                <div class="r-title"><a href="">WebApi - 错误处理</a></div>
                                <div class="r-time-1"><a href="">随笔散文</a></div>
                                <div class="r-time-1"><a href="">编辑</a></div>
                                <div class="r-time-1"><a href="">删除</a></div>
                                <div style="clear: both"></div>
                                <div class="r-subject">在WebApi2中，新增了一个新的返回类型，也就是IHttpActionResult，这样Web个新的返回类个新的返回类Api一共有4个返回类型。 1. void 2. HttpResponseMessage 直接返回一个http的response message 3. IHttpActionResult 在ap</div>
                            </div>
                        </div>
                    </div>

                    <div class="r-content-d">
                        <div class="row row-marginb">
                            <div class="col-md-1 bt-padding r-time-d">
                                <div class="r-date-t">
                                    <div class="r-date-year">2016</div>
                                    <div class="r-date-month">九</div>
                                </div>
                                <div class="r-date-b">
                                    18
                                </div>
                            </div>
                            <div class="col-md-10 bt-padding">
                                <div class="r-title"><a href="">WebApi - 错误处理</a></div>
                                <div class="r-time-1"><a href="">随笔散文</a></div>
                                <div class="r-time-1"><a href="">编辑</a></div>
                                <div class="r-time-1"><a href="">删除</a></div>
                                <div style="clear: both"></div>
                                <div class="r-subject">在WebApi2中，新增了一个新的返回类型，也就是IHttpActionResult，这样Web个新的返回类个新的返回类Api一共有4个返回类型。 1. void 2. HttpResponseMessage 直接返回一个http的response message 3. IHttpActionResult 在ap</div>
                            </div>
                        </div>
                    </div>

                    <div class="r-content-d">
                        <div class="row row-marginb">
                            <div class="col-md-1 bt-padding r-time-d">
                                <div class="r-date-t">
                                    <div class="r-date-year">2016</div>
                                    <div class="r-date-month">九</div>
                                </div>
                                <div class="r-date-b">
                                    18
                                </div>
                            </div>
                            <div class="col-md-10 bt-padding">
                                <div class="r-title"><a href="">WebApi - 错误处理</a></div>
                                <div class="r-time-1"><a href="">随笔散文</a></div>
                                <div class="r-time-1"><a href="">编辑</a></div>
                                <div class="r-time-1"><a href="">删除</a></div>
                                <div style="clear: both"></div>
                                <div class="r-subject">在WebApi2中，新增了一个新的返回类型，也就是IHttpActionResult，这样Web个新的返回类个新的返回类Api一共有4个返回类型。 1. void 2. HttpResponseMessage 直接返回一个http的response message 3. IHttpActionResult 在ap</div>
                            </div>
                        </div>
                    </div>--%>
                </div>
            </div>
        </div>
        <div class="footer">
            <div class="footer-detail">
                京 ICP 证 09002463 号|Copyright © 1999-2016, CSDN.NET, All Rights Reserved
            </div>
        </div>
    </form>
</body>
</html>
