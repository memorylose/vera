<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="UM.UI.Articles" %>
<%@ Register src="UserControl/Footer.ascx" tagname="Footer" tagprefix="uc1" %>
<%@ Register src="UserControl/HeaderTop.ascx" tagname="HeaderTop" tagprefix="uc2" %>
<%@ Register src="UserControl/HeaderWord.ascx" tagname="HeaderWord" tagprefix="uc3" %>
<%@ Register src="UserControl/UserInfo.ascx" tagname="UserInfo" tagprefix="uc4" %>
<%@ Register src="UserControl/ArticleType.ascx" tagname="ArticleType" tagprefix="uc5" %>
<%@ Register src="UserControl/ArticleDate.ascx" tagname="ArticleDate" tagprefix="uc6" %>
<%@ Register src="UserControl/HotArticleList.ascx" tagname="HotArticleList" tagprefix="uc7" %>
<%@ Register Src="UserControl/BlogName.ascx" TagName="BlogName" TagPrefix="uc8"  %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>文章详细页</title>
    <link href="/styles/bootstrap.min.css" rel="stylesheet" />
    <link href="/styles/NewIndex.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <div class="container">
                <div class="row">
                    <div class="col-md-2 header-col">
                    </div>
                    <div class="col-md-8 header-col"></div>
                    <div class="col-md-2 header-col">
                        <uc2:HeaderTop ID="HeaderTop1" runat="server" />
                        <%--<div class="header-login"><a href="">注册</a></div>
                        <div class="header-login"><a href="">登录</a></div>--%>
                    </div>
                </div>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <uc8:BlogName runat="server" id="BlogName" />
                <%--<a href="Index.aspx"><img src="/images/logo.png" class="header-img" /></a>--%>
            </div>
            <div class="row header-word">
                <div class="header-word-detail">
                    <uc3:HeaderWord ID="HeaderWord1" runat="server" />
                    <%--It is said that you will appear in the dreams of others when you fail to fall asleep.--%>
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
                        <%--<div class="row bt-margin">
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
                        </div>--%>
                        <uc4:UserInfo ID="UserInfo1" runat="server" />
                    </div>
                    <div class="l-personal-name">文章分类</div>
                    <div class="l-personal-detail">
                        <%--<div class="row bt-margin">
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
                        </div>--%>
                        <uc5:ArticleType ID="ArticleType1" runat="server" />
                    </div>
                    <div class="l-personal-name">文章存档</div>
                    <div class="l-personal-detail">
                        <%--<div class="row bt-margin">
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
                        </div>--%>
                        <uc6:ArticleDate ID="ArticleDate1" runat="server" />
                    </div>
                    <div class="l-personal-name">阅读排行</div>
                    <div class="l-personal-detail">
                        <%--<%=RankListhtml %>--%>
                        <uc7:HotArticleList ID="HotArticleList1" runat="server" />
                    </div>
                </div>
                <div class="col-md-9 r-content">
                    <div class="l-personal-name" style="margin-left: 20px;">欢迎来到我的生活坊</div>
                    <div class="r-content-d">
                        <div class="d-title"><%--WebApi 安全认证（一）--%><%=TitleHtml %></div>
                        <div class="d-title-line">
                            <div class="d-title-type">收藏</div>
                            <div class="d-title-type"><%--2015/08/08 23:22:00--%><%=CrDateHtml %></div>
                            <div class="d-title-type"><a href=""><%--心情随笔--%><%=TypeHtml %></a></div>
                            <div style="clear: both;"></div>
                        </div>

                        <div class="word-detail">
                            <%=ContentHtml %>
                            <%--问：据报道，昨天，美国国务院亚太事务助卿拉塞尔在美国参院外委会听证会上称，中国购买煤炭等经济活动为朝鲜提供了救命稻草，降低了全球对朝制裁效果。中方对此有何回应？

答：中方反对朝鲜发展核武器，致力于推动半岛无核化的立场是一贯、明确的。中国是负责任的国家，中方一直认真执行安理会涉朝决议。目前中朝间煤炭等矿产贸易均符合有关决议的规定，也符合中国国内的有关法规。

朝核问题的由来和症结不在中方，朝核问题的实质是朝美矛盾。美方应该承担起自己应有的责任，为朝核问题的解决发挥应有的建设性作用。中方将一如既往地为朝核问题的解决做出自己的努力。我们也再次敦促有关方面着眼大局，共同为推动半岛无核化进程、实现半岛和平稳定作出真正切实的努力。

问：国际货币基金组织（IMF）将在下周发布《全球经济展望》报告。IMF总裁拉加德28日表示，中国和印度经济增长相对较好，预计今年中国经济增速将在6%左右，印度增速将超过7%。巴西和俄罗斯将开始显露复苏迹象。这对下个月即将在印度果阿举办的金砖国家峰会意味着什么？

答：金砖国家是世界经济增长的重要引擎，IMF的预测再次证明了这一点。在全球经济复苏脆弱且不均衡的大背景下，金砖国家仍然具有巨大潜力，发展前景光明、后势可期，对世界经济的贡献不可或缺。

金砖国家领导人将于10月在印度果阿举行第八次会晤。我们期待金砖国家秉持开放、包容、合作、共赢的金砖精神，加强伙伴关系，深化务实合作，共同为促进世界经济强劲、可持续、平衡增长，为推动全球治理体系变革作出努力和贡献。

问：第一，美方称将继续对涉嫌违反涉朝贸易制裁决议的中国公司进行调查，中方对此有何评论？第二，你对中巴经济走廊安全现状有何评论？

答：关于第一个问题，第一，中方一贯全面、准确、认真执行安理会涉朝决议，履行自己在防扩散等方面的国际义务，作出的努力有目共睹。

第二，任何企业或个人如有违规之举，一经查实，我们会依法依规严肃处理。

第三，我们愿在相互尊重、平等相待的前提下同有关国家开展合作，同时反对任何国家根据其国内法对中方实体和个人实施所谓的“长臂管辖”。--%>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class="footer">
            <%--<div class="footer-detail">
                京 ICP 证 09002463 号|Copyright © 1999-2016, CSDN.NET, All Rights Reserved
            </div>--%>
            <uc1:Footer ID="Footer1" runat="server" />
        </div>
    </form>
</body>
</html>
