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
    public partial class Article : System.Web.UI.Page
    {
        public string Articleshtml = "";
        //public string Pageheadhtml = "";
        public int articleId = 0;
        //public string HomePagehtml = "";
        //public string MyArticlehtml = "";
        //public string Popularhtml = "";
        //public string Abouttml = "";
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
            //    DataSet ds = userReg.GetUserNickname(username);
            //    string nickname = ds.Tables[0].Rows[0]["NickName"].ToString();
            //    Pageheadhtml += nickname + "'s Blog";
            //}
            //Pageheadhtml += "Welcome to Blog";

            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet allarticleDs = userReg.ShowArticle();
            for (int i = 0; i < allarticleDs.Tables[0].Rows.Count; i++)
            {
                articleId = Convert.ToInt32(allarticleDs.Tables[0].Rows[i]["ArticleId"]);
                string title = allarticleDs.Tables[0].Rows[i]["Title"].ToString();
                string crDate = allarticleDs.Tables[0].Rows[i]["CreateDate"].ToString();
                string typeName = allarticleDs.Tables[0].Rows[i]["TypeName"].ToString();
                string summary = allarticleDs.Tables[0].Rows[i]["Summary"].ToString();
                if (summary == "")
                {
                    summary = allarticleDs.Tables[0].Rows[i]["Contents"].ToString().Substring(0, 200);
                }

                Articleshtml += "<div class=\"row\">";
                Articleshtml += "<div class=\"col-md-12 content-title\"><a href=\"ArticleDetail.aspx?id=" + articleId + "\">" + title + "</a></div>" + "<br/>";//+"<br/>"
                Articleshtml += "<div class=\"col-md-12 content-date\"><span>" + crDate + "</span><span>-</span><span>" + typeName + "</span></div>" + "<br/>";//+"<br/>"
                Articleshtml += "<div class=\"col-md-12 content-t\">" + summary + "<br/>";//+"<br/>"
                Articleshtml += "</div>";
                Articleshtml += "</div>";



                //Articleshtml += "<div class=\"row\">" + "<br/>";
                //Articleshtml += "<div class=\"col-md-12 content-title\">";
                //Articleshtml += "<a href=\"ArticleDetail.aspx?id=" + articleId + "\">";
                //Articleshtml += title;
                //Articleshtml += "</a></div>" + "<br/>";
                //Articleshtml += "<div class=\"col-md-12 content-date\"><span>" + crDate + "</span><span>-</span><span>" + typeName + "</span></div>" + "<br/>";
                //Articleshtml += "<div class=\"col-md-12 content-t\">";
                //Articleshtml += summary;
                //Articleshtml += "</div>" + "<br/>";
                //Articleshtml += "</div>" + "<br/>";
            }

            //int userId = userReg.GetUserId(username);

            //DataSet articleDs = userReg.ShowArticle(userId);
            //for (int i = 0; i < articleDs.Tables[0].Rows.Count; i++)
            //{
            //    articleId = Convert.ToInt32(articleDs.Tables[0].Rows[i]["ArticleId"]);
            //    string title = articleDs.Tables[0].Rows[i]["Title"].ToString();
            //    string crDate = articleDs.Tables[0].Rows[i]["CreateDate"].ToString();
            //    string typeName = articleDs.Tables[0].Rows[i]["TypeName"].ToString();
            //    string summary = articleDs.Tables[0].Rows[i]["Summary"].ToString();
            //    if (summary == "")
            //    {
            //        summary = articleDs.Tables[0].Rows[i]["Contents"].ToString().Substring(0, 2);
            //    }


            //    Modify part
            //    Articlehtml += "<div style=\"height: 30px; text - align: center; font - size: 13px; margin - bottom: 20px; float: left; margin - left: 20px; \">" + "<br/>";
            //    Articlehtml += "<a href=\"ArticleModify.aspx?id=" + articleId + "\">";
            //    Articlehtml += "Mofify" + "<br/>";
            //    Articlehtml += "</a>" + "<br/>";
            //    Articlehtml += "</div>" + "<br/>";
            //    Articlehtml += "</div>" + "<br/>";
            //}
        }
    }


}
