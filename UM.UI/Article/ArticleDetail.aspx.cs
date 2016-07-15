using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UM.BusinessLogic;

namespace UM.UI.Article
{
    public partial class ArticleDetail : System.Web.UI.Page
    {
        public string ArticleDetailhtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //string username = string.Empty;
            //if (Session["user"] == null)
            //{
            //    Response.Redirect("../Login.aspx");
            //}
            //else
            //{
            //    //get user information
            //    username = Session["user"].ToString();
            //}
            //就当现在你访问的是1的文章
            int articleId = Convert.ToInt32(Request.QueryString["id"]);

            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet contentDs = userReg.ArticleDetails(articleId);
            string title = contentDs.Tables[0].Rows[0]["Title"].ToString();
            string crDate = contentDs.Tables[0].Rows[0]["CreateDate"].ToString();
            string articleType = contentDs.Tables[0].Rows[0]["TypeName"].ToString();
            string author = contentDs.Tables[0].Rows[0]["UserName"].ToString();
            string content = contentDs.Tables[0].Rows[0]["Contents"].ToString();
            
            

            ArticleDetailhtml += "<div class=\"row\">";
            ArticleDetailhtml += "<div class=\"col-md-12 content-detail-top\">";
            ArticleDetailhtml += "<span>当前位置：</span><span>";
            ArticleDetailhtml += "<a href=\"Article.aspx\">";
            ArticleDetailhtml += "首页" + "</a></span><span>></span><span>";
            ArticleDetailhtml += "<a href=\"Article.aspx\">" + articleType + "</a></span><span>></span><span>正文</span>";
            ArticleDetailhtml += "</div>" + "<br/>";
            ArticleDetailhtml += "<div class=\"col-md-12 content-detail-title\">";
            ArticleDetailhtml += title;
            ArticleDetailhtml += "</div>" + "<br/>";
            ArticleDetailhtml += "<div class=\"col-md-12 content-detail-time\">";
            ArticleDetailhtml += "<span>" + crDate + "</span><span> - </span><span>" + author + "</span>";
            ArticleDetailhtml += "</div>" + "<br/>";
            ArticleDetailhtml += "<div class=\"col-md-12 content-detail-c\">";
            ArticleDetailhtml += content;
            ArticleDetailhtml += "</div>" + "<br/>";
            ArticleDetailhtml += "</div>" + "<br/>";
        }
    }
}