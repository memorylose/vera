using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UM.BusinessLogic;
using UM.Utility;

namespace UM.Pager
{
    public class PageDevision : System.Web.UI.Page
    {
        UserRegisterBusiness userReg = new UserRegisterBusiness();
        DataSet ds;

        public void DevidePage(int pageSize, string request, string link)
        {
            StringBuilder PageDevisionhtml = new StringBuilder();
            int articelNumber = userReg.CountNumber();
            int pageNumber = 0;
            int curPage = 0;
            int prePage = 0;
            int nextPage = 0;
            int x = articelNumber % pageSize;
            if (x > 0)
            {
                pageNumber = articelNumber / pageSize + 1;
            }
            else if (x == 0)
            {
                pageNumber = articelNumber / pageSize;
            }

            if (request != null && userReg.ValidatePageId(request))
            {
                curPage = Convert.ToInt32(request);
                if (curPage == 1 && curPage == pageNumber)
                {
                    prePage = curPage;
                    nextPage = curPage;
                }
                else if (curPage == 1 && curPage != pageNumber)
                {
                    prePage = curPage;
                    nextPage = curPage + 1;
                }
                else if (curPage != 1 && curPage == pageNumber)
                {
                    prePage = curPage - 1;
                    nextPage = curPage;
                }
                else
                {
                    prePage = curPage - 1;
                    nextPage = curPage + 1;
                }
            }
            else
            {
                curPage = 1;
                prePage = curPage;
                if (pageNumber > 1)
                {
                    nextPage = curPage + 1;
                }
                else
                {
                    nextPage = curPage;
                }
            }

            PageDevisionhtml.Append(link + prePage.ToString() + "\">上一页</a>");
            for (int j = 1; j <= pageNumber; j++)
            {
                PageDevisionhtml.Append(link + j.ToString() + "\">" + j.ToString() + "</a>");
            }
            PageDevisionhtml.Append(link + nextPage.ToString() + "\">下一页</a>");

            int beginRowNumber = (curPage - 1) * pageSize + 1;
            int endRowNumber = curPage * pageSize;
            ShowArtList(beginRowNumber, endRowNumber);
        }

        public void ShowArtList(int beginRowNumber, int endRowNumber)
        {
            StringBuilder ArticleListhtml = new StringBuilder();
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
