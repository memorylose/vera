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
                <div class="col-md-3" style="padding: 0;">
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
                        <div class="row bt-margin">
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
                        </div>
                    </div>
                </div>
                <div class="col-md-8" style="background-color:white; margin-left:10px;">
                    <div class="row">
                        <div class="col-md-1 bt-padding" style="margin-left:10px;">
                            <div class="r-date-t">
                                <div class="r-date-year">2016</div>
                                <div class="r-date-month">九</div>
                            </div>
                            <div class="r-date-b">
                                18
                            </div>

                        </div>
                        <div class="col-md-10 test">2</div>

                    </div>





                </div>
            </div>
        </div>
    </form>
</body>
</html>
