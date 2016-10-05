using System;
using System.Data;
using UM.BusinessLogic;

namespace UM.UI.UserControl
{
    public partial class ArticleDate : System.Web.UI.UserControl
    {
        public string ArticleDateHtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowArticleDate();
        }

        private void ShowArticleDate()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet dsArtDate = userReg.ArticleDate();
            for (int i = 0; i < dsArtDate.Tables[0].Rows.Count; i++)
            {
                ArticleDateHtml += "<div class=\"row bt-margin\">";
                ArticleDateHtml += "<div class=\"l-cate-name\"><a href=\"\">" + DateTime.Parse(dsArtDate.Tables[0].Rows[i]["CrDate"].ToString()).Year.ToString() + "年" + DateTime.Parse(dsArtDate.Tables[0].Rows[i]["CrDate"].ToString()).Month.ToString() + "月" + "</a></div>";
                ArticleDateHtml += "<div class=\"l-cate-name-d\">(" + dsArtDate.Tables[0].Rows[i]["DateCount"].ToString() + ")</div>";
                ArticleDateHtml += "</div>";
            }
        }
    }
}