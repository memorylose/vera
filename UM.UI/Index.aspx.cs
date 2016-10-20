using System;
using System.Data;
using System.Text;
using UM.BusinessLogic;
using UM.Utility;
using UM.Pager;


namespace UM.UI
{
    public partial class Index : System.Web.UI.Page
    {
        public StringBuilder ArticleListhtml = new StringBuilder();
        public StringBuilder PageDevisionhtml = new StringBuilder();
        UserRegisterBusiness userReg = new UserRegisterBusiness();
        DataSet ds;

        public void Page_Load(object sender, EventArgs e)
        {
            int pageSize = 10;
            int beginRowNumber;
            int endRowNumber;
            int articleNumber = userReg.CountNumber();
            string request = Request.QueryString["pageid"];
            string link = "<a href=\"Index.aspx?pageid=";
            PageDevision pageDev = new PageDevision();
            PageDevisionhtml = pageDev.DevidePage(articleNumber, pageSize, request, link, out beginRowNumber, out endRowNumber);
            ShowArtList(beginRowNumber, endRowNumber);
        }


        /// <summary>
        /// Show articles on home page
        /// </summary>
        //private void ShowArticleList()
        //{
        //    //DataSet ds;
        //    string username = string.Empty;
        //    string title = string.Empty;
        //    string crDate = string.Empty;
        //    string crYear = string.Empty;
        //    string crMonth = string.Empty;
        //    string month = string.Empty;
        //    string crDay = string.Empty;
        //    string typeName = string.Empty;
        //    string summary = string.Empty;
        //    string author = string.Empty;
        //    string typeId = string.Empty;
        //    if (Request.QueryString["id"] != null && userReg.ValidateTypeId(Request.QueryString["id"]))
        //    {
        //        int TypeId = Convert.ToInt32(Request.QueryString["id"]);
        //        ds = userReg.ShowArticleTypeList(TypeId);
        //    }
        //    else
        //    {
        //        ds = userReg.ShowArticle();
        //    }
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        int articleId = Convert.ToInt32(ds.Tables[0].Rows[i]["ArticleId"]);
        //        title = ds.Tables[0].Rows[i]["Title"].ToString();
        //        crDate = ds.Tables[0].Rows[i]["CreateDate"].ToString();
        //        crYear = DateTime.Parse(crDate).Year.ToString();
        //        crMonth = DateTime.Parse(crDate).Month.ToString();
        //        month = userReg.ShowMonth(crMonth);
        //        crDay = DateTime.Parse(crDate).Day.ToString();
        //        typeName = ds.Tables[0].Rows[i]["TypeName"].ToString();
        //        summary = ds.Tables[0].Rows[i]["Summary"].ToString();
        //        author = ds.Tables[0].Rows[i]["UserName"].ToString();
        //        typeId = ds.Tables[0].Rows[i]["TypeId"].ToString();
        //        if (summary == "")
        //        {
        //            string contents = ds.Tables[0].Rows[i]["Contents"].ToString();
        //            contents = System.Text.RegularExpressions.Regex.Replace(contents, RegexConstant.Htmlmark, "");
        //            if (contents.Length < 100)
        //            {
        //                summary = contents;
        //            }
        //            else
        //            {
        //                summary = contents.Substring(0, 100);
        //                summary = summary.Substring(0, 99) + System.Text.RegularExpressions.Regex.Replace(summary.Substring(99, 1), RegexConstant.AlphaNumber, "");
        //                summary += "......";
        //            }
        //        }

        //        ArticleListhtml.Append("<div class=\"r-content-d\">");
        //        ArticleListhtml.Append("<div class=\"row row-marginb\">");
        //        ArticleListhtml.Append("<div class=\"col-md-1 bt-padding r-time-d\">");
        //        ArticleListhtml.Append("<div class=\"r-date-t\">");
        //        ArticleListhtml.Append("<div class=\"r-date-year\">" + crYear + "</div>");
        //        ArticleListhtml.Append("<div class=\"r-date-month\">" + month + "</div>");
        //        ArticleListhtml.Append("</div>");
        //        ArticleListhtml.Append("<div class=\"r-date-b\">");
        //        ArticleListhtml.Append(crDay);
        //        ArticleListhtml.Append("</div>");
        //        ArticleListhtml.Append("</div>");
        //        ArticleListhtml.Append("<div class=\"col-md-10 bt-padding\">");
        //        ArticleListhtml.Append("<div class=\"r-title\"><a href=\"Articles.aspx?id=" + articleId + "\">" + title + "</a></div>");
        //        ArticleListhtml.Append("<div class=\"r-time-1\"><a href=\"Index.aspx?id=" + typeId + "\">" + typeName + "</a></div>");
        //        if (Session["user"] != null)
        //        {
        //            username = Session["user"].ToString();
        //            if (username == author)
        //            {
        //                ArticleListhtml.Append("<div class=\"r-time-1\"><a href=\"Article/ArticleModify.aspx?id=" + articleId + "\">" + "编辑" + "</a></div>");
        //                ArticleListhtml.Append("<div class=\"r-time-1\"><a href=\"Article/ArticleModify.aspx?id=" + articleId + "\">" + "删除" + "</a></div>");
        //            }
        //            else
        //            {
        //                ArticleListhtml.Append("");
        //            }
        //        }
        //        else
        //        {
        //            ArticleListhtml.Append("");
        //        }
        //        ArticleListhtml.Append("<div style=\"clear: both\"></div>");
        //        ArticleListhtml.Append("<div class=\"r-subject\">" + summary + "</div>");
        //        ArticleListhtml.Append("</div>");
        //        ArticleListhtml.Append("</div>");
        //        ArticleListhtml.Append("</div>");
        //    }
        //}

        //private void DevidePage()
        //{
        //    int articelNumber = userReg.CountNumber();
        //    int pageNumber = 0;
        //    int curPage = 0;
        //    int prePage = 0;
        //    int nextPage = 0;
        //    int x = articelNumber % 10;
        //    if (x > 0)
        //    {
        //        pageNumber = articelNumber / 10 + 1;
        //    }
        //    else if (x == 0)
        //    {
        //        pageNumber = articelNumber / 10;
        //    }

        //    if (Request.QueryString["pageid"] != null && userReg.ValidatePageId(Request.QueryString["pageid"]))
        //    {
        //        curPage = Convert.ToInt32(Request.QueryString["pageid"]);
        //        if (curPage == 1 && curPage == pageNumber)
        //        {
        //            prePage = curPage;
        //            nextPage = curPage;
        //        }
        //        else if (curPage == 1 && curPage != pageNumber)
        //        {
        //            prePage = curPage;
        //            nextPage = curPage + 1;
        //        }
        //        else if (curPage != 1 && curPage == pageNumber)
        //        {
        //            prePage = curPage - 1;
        //            nextPage = curPage;
        //        }
        //        else
        //        {
        //            prePage = curPage - 1;
        //            nextPage = curPage + 1;
        //        }
        //    }
        //    else
        //    {
        //        curPage = 1;
        //        prePage = curPage;
        //        if (pageNumber > 1)
        //        {
        //            nextPage = curPage + 1;
        //        }
        //        else
        //        {
        //            nextPage = curPage;
        //        }
        //    }

        //    PageDevisionhtml.Append("<a href=\"Index.aspx?pageid=" + prePage.ToString() + "\">上一页</a>");
        //    for (int j = 1; j <= pageNumber; j++)
        //    {                
        //        PageDevisionhtml.Append("<a href=\"Index.aspx?pageid=" + j.ToString() + "\">" + j.ToString() + "</a>");
        //    }
        //    PageDevisionhtml.Append("<a href=\"Index.aspx?pageid=" + nextPage.ToString() + "\">下一页</a>");

        //    int beginRowNumber = (curPage - 1) * 10 + 1;
        //    int endRowNumber = curPage * 10;
        //    ShowArtList(beginRowNumber, endRowNumber);
        //}

        public void ShowArtList(int beginRowNumber, int endRowNumber)
        {
            ds = userReg.ShowPageDevision(beginRowNumber, endRowNumber);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int articleId = Convert.ToInt32(ds.Tables[0].Rows[i]["ArticleId"]);
                string title = ds.Tables[0].Rows[i]["Title"].ToString();
                string crDate = ds.Tables[0].Rows[i]["CreateDate"].ToString();
                string crYear = DateTime.Parse(crDate).Year.ToString();
                string crMonth = DateTime.Parse(crDate).Month.ToString();
                string month = userReg.ShowMonth(crMonth);
                string crDay = DateTime.Parse(crDate).Day.ToString();
                string typeName = ds.Tables[0].Rows[i]["TypeName"].ToString();
                string summary = ds.Tables[0].Rows[i]["Summary"].ToString();
                string author = ds.Tables[0].Rows[i]["UserName"].ToString();
                string typeId = ds.Tables[0].Rows[i]["TypeId"].ToString();
                if (summary == "")
                {
                    string contents = ds.Tables[0].Rows[i]["Contents"].ToString();
                    contents = System.Text.RegularExpressions.Regex.Replace(contents, RegexConstant.Htmlmark, "");
                    if (contents.Length < 100)
                    {
                        summary = contents;
                    }
                    else
                    {
                        summary = contents.Substring(0, 100);
                        summary = summary.Substring(0, 99) + System.Text.RegularExpressions.Regex.Replace(summary.Substring(99, 1), RegexConstant.AlphaNumber, "");
                        summary += "......";
                    }
                }
                ArticleListhtml.Append("<div class=\"r-content-d\">");
                ArticleListhtml.Append("<div class=\"row row-marginb\">");
                ArticleListhtml.Append("<div class=\"col-md-1 bt-padding r-time-d\">");
                ArticleListhtml.Append("<div class=\"r-date-t\">");
                ArticleListhtml.Append("<div class=\"r-date-year\">" + crYear + "</div>");
                ArticleListhtml.Append("<div class=\"r-date-month\">" + month + "</div>");
                ArticleListhtml.Append("</div>");
                ArticleListhtml.Append("<div class=\"r-date-b\">");
                ArticleListhtml.Append(crDay);
                ArticleListhtml.Append("</div>");
                ArticleListhtml.Append("</div>");
                ArticleListhtml.Append("<div class=\"col-md-10 bt-padding\">");
                ArticleListhtml.Append("<div class=\"r-title\"><a href=\"Articles.aspx?id=" + articleId + "\">" + title + "</a></div>");
                ArticleListhtml.Append("<div class=\"r-time-1\"><a href=\"Index.aspx?id=" + typeId + "\">" + typeName + "</a></div>");
                if (Session["user"] != null)
                {
                    string username = Session["user"].ToString();
                    if (username == author)
                    {
                        ArticleListhtml.Append("<div class=\"r-time-1\"><a href=\"Article/ArticleModify.aspx?id=" + articleId + "\">" + "编辑" + "</a></div>");
                        ArticleListhtml.Append("<div class=\"r-time-1\"><a href=\"Article/ArticleModify.aspx?id=" + articleId + "\">" + "删除" + "</a></div>");
                    }
                    else
                    {
                        ArticleListhtml.Append("");
                    }
                }
                else
                {
                    ArticleListhtml.Append("");
                }
                ArticleListhtml.Append("<div style=\"clear: both\"></div>");
                ArticleListhtml.Append("<div class=\"r-subject\">" + summary + "</div>");
                ArticleListhtml.Append("</div>");
                ArticleListhtml.Append("</div>");
                ArticleListhtml.Append("</div>");
            }
        }
    }
}

