<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArticleDetail.aspx.cs" Inherits="UM.UI.Article.ArticleDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Article Detail</title>
    <link href="/styles/bootstrap.min.css" rel="stylesheet" />
    <link href="/styles/index.css" rel="stylesheet" />
    <script src="/scripts/jquery-3.0.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid" style="margin-top: 20px;">
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8">
                    <div class="row">
                        <div class="col-md-3">
                            <div class="top-left">Cass Fan's Blog</div>
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
                <div class="col-md-8" style="padding: 0;">
                    <div class="content-main">
                        <div class="row">
                            <div class="col-md-8">
                                <%=ArticleDetailhtml%>
                                <%--<div class="row">
                                    <div class="col-md-12 content-detail-top">
                                        <span>当前位置：</span><span><a href="">首页</a></span><span>></span><span><a href="">随笔散文</a></span><span>></span><span>正文</span>
                                    </div>
                                    <div class="col-md-12 content-detail-title">
                                        同学，你的努力不叫努力，叫重复劳动，明白吗！
                                    </div>
                                    <div class="col-md-12 content-detail-time">
                                        <span>2016.7.14 22:00</span><span> - </span><span>Vera</span>
                                    </div>
                                    <div class="col-md-12 content-detail-c">
                                        你身边有没有这样的人，日日早起夜夜晚睡，经常加班加点，你约他出去，他总说没时间，似乎永远有做不完的事。但是从老板到同事，提起这人就是摇摇头摆摆手，一副一言难尽的样子。他们很忙，做的事却不漂亮。
那么他们在忙什么？这似乎很奇怪，他们如此努力，为什么事情总是做不好呢，问题究竟是在什么地方？
因为他们并不算努力，只是重复劳动。<br />
                                        记得原来上学的时候，有一个同桌，别人学习的时间他也在学，别人玩的时间他也在玩，但是成绩一直不是很好。他总说自己脑子慢。有一次考完试，我看他在写什么东西，我过去看了一眼，发现他把错的题，一字不差的抄到了本子上。
我问他：“为什么每道题都要抄呢？试卷上不是有么？”
他非常认真的说：“不行啊，试卷太多容易乱，一本错题集复习起来方便。”并且一脸学习方法优良的表情，似乎站在的勤奋和道德的制高点。
我又问：“那就写核心、重点行不行呢？”
他又说：“不行啊，以后翻起来很容易看不懂哪是哪？”
我再说：“这些错题的原因你研究过了吗？”
他疲惫的说：“我现在哪有时间研究这个，等我抄完再说吧！”
我原来有一个同事，经过他电脑旁边的时候，他总是在写文档，写呀写似乎写不完的样子。有一次我问他：“怎么这么多东西要写？咱们最近有这么多案子吗？”
他回答：“老板不满意，推了重写，改几遍下来，就相当于多了好几个案子的量啊！”
我又问：“他为啥不满意啊？”<br />
                                        他很郁闷：“老板说我写的东西不是他想要的，他也不说清楚。”
我很纳闷：“你动笔之前可以先花点时间沟通呀。”
他疲惫的说：“哪有时间啊，每次要的那么急，文案又这么多，马上开始写都不一定写的完呢！”
【他们究竟在忙什么？】
为什么有那么一群人，不用很忙却得到了很多赞誉？抄题的他说班里同学：“你看那个刘X，平时也不怎么熬夜，还考了第三名，肯定是他爸爸有钱，说不定贿赂了老师给他泄题呢。”
加班的他说单位同事：“你看那个王X，也不怎么加班，到点就下班，现在都升经理了，论资历，应该是我的。老板太偏心了。”
【为什么有的人就显得那么轻松呢。】<br />
                                        问问刘X，他说：“错题我先研究为什么错，概念不清、思路错误还是马虎。概念不清的重新研究概念，思路错误的回忆当时的思路，正确答案的思路是什么。以后同类的题是否都是一样的思路。只有特别有价值的才会抄下来。”
问问王X，他说：“写东西之前，我先问清楚老板的要求、目的和背景。他希望达到什么效果，东西是拿给什么人看的，对内还是对外，专业人士还是业余人士。写之前还要先列出大纲，给老板看，确定还有没有增加减少或者修改。确定不会再改之后在动笔。最后完稿的时候通常跟老板的需求都差不多了。”
【这就是努力和重复劳动的区别】
重复劳动是将时间和精力投在事情的低效率环节中，努力是将时间和精力投入在事情最高效的环节中。所以为什么说：“最可怕的是比你聪明还比你努力，而不是说比你聪明的人还比你用更多的时间。”
重复劳动最大的特征就是反复的去做对事情结果没有实质影响的实情。就拿学习来说，最重要的是做对题，要充分理解每一题的思路。至于抄在错题本上的字迹是不是美观，排列是不是工整，对于解题能力不会有一点提升，没有实质影响。
重点来了【如何摆脱重复劳动】<br />
                                        要摆脱重复劳动，首先要分清出最重要的环节。对目标最有帮助的因素，就是最重要的环节。比如写文案来说，最重要的目的是老板满意，那么就要围绕老板满意去投入精力。最常见的情况就是：
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
