using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UM.BusinessLogic;

namespace UM.UI
{
    public partial class Articles : System.Web.UI.Page
    {
        public string RankListhtml = "";
        public string Pageheadhtml = "";
        public string TitleHtml = "";
        public string CrDateHtml="";
        public string TypeHtml = "";
        public string ContentHtml = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowPageHead();
            ShowHotArticle();
            ShowArticleDetail();
        }

        public void ShowPageHead()
        {
            Pageheadhtml += "<div class=\"header-login\"><a href=\"Register.aspx\">注册</a></div>";
            Pageheadhtml += "<div class=\"header-login\"><a href=\"Login.aspx\">登录</a></div>";
        }

        public void ShowHotArticle()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet ds = userReg.HotArticle();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string title = ds.Tables[0].Rows[i]["Title"].ToString();
                if (title.Length >= 15)
                {
                    title = title.Substring(0, 15);
                    title += "...";
                }
                RankListhtml += "<div class=\"row bt-margin\">";
                RankListhtml += "<div class=\"l-read-name\"><a href=\"ArticleDetail.aspx?id=" + Convert.ToInt32(ds.Tables[0].Rows[i]["ArticleId"]) + "\">" + title + "</a></div>";
                RankListhtml += "<div class=\"l-read-name-d\">(239)</div>";
                RankListhtml += "</div>";
            }
        }

        public void ShowArticleDetail()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            if (!userReg.ValidateArticleId(Request.QueryString["id"]))
            {
                Response.Redirect("Article.aspx");
            }
            else
            {
                int articleId = Convert.ToInt32(Request.QueryString["id"]);
                DataSet dsArtDetail = userReg.ArticleDetails(articleId);
                if (dsArtDetail.Tables[0].Rows.Count > 0)
                {
                    TitleHtml += dsArtDetail.Tables[0].Rows[0]["Title"].ToString();
                    CrDateHtml += dsArtDetail.Tables[0].Rows[0]["CreateDate"].ToString();
                    TypeHtml += dsArtDetail.Tables[0].Rows[0]["TypeName"].ToString();
                    ContentHtml += dsArtDetail.Tables[0].Rows[0]["Contents"].ToString();
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }
            }          
        }
    }
}