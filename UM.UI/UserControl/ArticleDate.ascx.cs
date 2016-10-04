using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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

        public void ShowArticleDate()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet dsArtDate = userReg.ArticleDate();
            string ArticleDate = string.Empty;
            string Count = string.Empty;
            string crYear = string.Empty;
            string crMonth = string.Empty;
            for (int i = 0; i < dsArtDate.Tables[0].Rows.Count; i++)
            {
                ArticleDate = dsArtDate.Tables[0].Rows[i]["CrDate"].ToString();
                Count = dsArtDate.Tables[0].Rows[i]["DateCount"].ToString();
                crYear = DateTime.Parse(ArticleDate).Year.ToString();
                crMonth = DateTime.Parse(ArticleDate).Month.ToString();
                ArticleDateHtml += "<div class=\"row bt-margin\">";
                ArticleDateHtml += "<div class=\"l-cate-name\"><a href=\"\">" + crYear + "年" + crMonth + "月" + "</a></div>";
                ArticleDateHtml += "<div class=\"l-cate-name-d\">(" + Count + ")</div>";
                ArticleDateHtml += "</div>";
            }
        }
    }
}