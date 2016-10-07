using System;
using System.Data;
using UM.BusinessLogic;
using UM.Utility;

namespace UM.UI
{
    public partial class Index : System.Web.UI.Page
    {
        public string ArticleDetailhtml = "";
        public string ArticleListhtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowArticleList();
        }


        /// <summary>
        /// Show articles on home page
        /// </summary>
        private void ShowArticleList()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet ds;
            string username = string.Empty;
            string title = string.Empty;
            string crDate = string.Empty;
            string crYear = string.Empty;
            string crMonth = string.Empty;
            string month = string.Empty;
            string crDay = string.Empty;
            string typeName = string.Empty;
            string summary = string.Empty;
            string author = string.Empty;

            if (Request.QueryString["id"] != null && userReg.ValidateTypeId(Request.QueryString["id"]))
            {
                int TypeId = Convert.ToInt32(Request.QueryString["id"]);
                ds = userReg.ShowArticleTypeList(TypeId);
            }              
            else
            {
                ds = userReg.ShowArticle();
            }
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int articleId = Convert.ToInt32(ds.Tables[0].Rows[i]["ArticleId"]);
                title = ds.Tables[0].Rows[i]["Title"].ToString();
                crDate = ds.Tables[0].Rows[i]["CreateDate"].ToString();
                crYear = DateTime.Parse(crDate).Year.ToString();
                crMonth = DateTime.Parse(crDate).Month.ToString();
                month = userReg.ShowMonth(crMonth);
                crDay = DateTime.Parse(crDate).Day.ToString();
                typeName = ds.Tables[0].Rows[i]["TypeName"].ToString();
                summary = ds.Tables[0].Rows[i]["Summary"].ToString();
                author = ds.Tables[0].Rows[i]["UserName"].ToString();

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
                ArticleListhtml += "<div class=\"r-content-d\">";
                ArticleListhtml += "<div class=\"row row-marginb\">";
                ArticleListhtml += "<div class=\"col-md-1 bt-padding r-time-d\">";
                ArticleListhtml += "<div class=\"r-date-t\">";
                ArticleListhtml += "<div class=\"r-date-year\">" + crYear + "</div>";
                ArticleListhtml += "<div class=\"r-date-month\">" + month + "</div>";
                ArticleListhtml += "</div>";
                ArticleListhtml += "<div class=\"r-date-b\">";
                ArticleListhtml += crDay;
                ArticleListhtml += "</div>";
                ArticleListhtml += "</div>";
                ArticleListhtml += "<div class=\"col-md-10 bt-padding\">";
                ArticleListhtml += "<div class=\"r-title\"><a href=\"Articles.aspx?id=" + articleId + "\">" + title + "</a></div>";
                ArticleListhtml += "<div class=\"r-time-1\"><a href=\"\">" + typeName + "</a></div>";
                if (Session["user"] != null)
                {
                    username = Session["user"].ToString();
                    if (username == author)
                    {
                        ArticleListhtml += "<div class=\"r-time-1\"><a href=\"Article/ArticleModify.aspx?id=" + articleId + "\">" + "编辑" + "</a></div>";
                        ArticleListhtml += "<div class=\"r-time-1\"><a href=\"Article/ArticleModify.aspx?id=" + articleId + "\">" + "删除" + "</a></div>";
                    }
                    else
                    {
                        ArticleListhtml += "";
                    }
                }
                else
                {
                    ArticleListhtml += "";
                }
                ArticleListhtml += "<div style=\"clear: both\"></div>";
                ArticleListhtml += "<div class=\"r-subject\">" + summary + "</div>";
                ArticleListhtml += "</div>";
                ArticleListhtml += "</div>";
                ArticleListhtml += "</div>";
            }
        }
    }
}
