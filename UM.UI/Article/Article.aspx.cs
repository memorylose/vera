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
        public string Pageheadhtml = "";
        public int articleId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = string.Empty;
            if (Session["user"] == null)
            {
                Response.Redirect("../Login.aspx");
            }
            else
            {
                //get user information
                username = Session["user"].ToString();
                Pageheadhtml += username + "'s Blog";
            }

            UserRegisterBusiness userReg = new UserRegisterBusiness();
            int userId = userReg.GetUserId(username);


            DataSet articleDs = userReg.ShowArticle(userId);
            
            for (int i = 0; i < articleDs.Tables[0].Rows.Count; i++)
            {
                articleId = Convert.ToInt32(articleDs.Tables[0].Rows[i]["ArticleId"]);
                string title = articleDs.Tables[0].Rows[i]["Title"].ToString();
                string crDate = articleDs.Tables[0].Rows[i]["CreateDate"].ToString();
                string typeName = articleDs.Tables[0].Rows[i]["TypeName"].ToString();
                string summary = articleDs.Tables[0].Rows[i]["Summary"].ToString();
                if (summary == "")
                {
                    summary = articleDs.Tables[0].Rows[i]["Contents"].ToString().Substring(0, 2);
                }


                Articleshtml += "<div class=\"row\">" + "<br/>";
                Articleshtml += "<div class=\"col-md-12 content-title\">";
                Articleshtml += "<a href=\"ArticleDetail.aspx?id="+ articleId + "\">";
                Articleshtml += title;
                 Articleshtml += "</a></div>" + "<br/>";
                Articleshtml += "<div class=\"col-md-12 content-date\"><span>" + crDate + "</span><span>-</span><span>" + typeName + "</span></div>" + "<br/>";
                Articleshtml += "<div class=\"col-md-12 content-t\">";
                Articleshtml += summary;
                Articleshtml += "</div>" + "<br/>";
                Articleshtml += "</div>" + "<br/>";


                //Articlehtml += "<div style=\"height: 30px; \">";
                //Articlehtml += "<div style=\"height: 30px; width: 500px; text - align: center; font - size: 13px; margin - bottom: 20px; float: left; \">" + "<br/>";
                //Articlehtml += "<a href=\"ArticleDetail.aspx?id=" + articleId + "\">";
                //Articlehtml += articleDs.Tables[0].Rows[i]["Title"].ToString();
                //Articlehtml += "</a>" + "<br/>";
                //Articlehtml += "</div>" + "<br/>";
                //Articlehtml += "<div style=\"height: 30px; text - align: center; font - size: 13px; margin - bottom: 20px; float: left; margin - left: 20px; \">" + "<br/>";
                //Articlehtml += articleDs.Tables[0].Rows[i]["CreateDate"].ToString() + "<br/>";
                //Articlehtml += "</div>" + "<br/>";

                //Modify part
                //Articlehtml += "<div style=\"height: 30px; text - align: center; font - size: 13px; margin - bottom: 20px; float: left; margin - left: 20px; \">" + "<br/>";
                //Articlehtml += "<a href=\"ArticleModify.aspx?id=" + articleId + "\">";
                //Articlehtml += "Mofify" + "<br/>";
                //Articlehtml += "</a>" + "<br/>";
                //Articlehtml += "</div>" + "<br/>";
                //Articlehtml += "</div>" + "<br/>";
            }
        }


    }
}