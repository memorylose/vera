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
        public string ArticleTypehtml = "";
        public string Titlehtml = "";
        public string CreateDatehtml = "";
        public string Authorhtml = "";
        public string Updatehtml = "";
        public string Contenthtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();

            if (!userReg.ValidateArticleId(Request.QueryString["id"]))
            {
                Response.Redirect("Article.aspx");
            }
            else
            {
                int articleId = Convert.ToInt32(Request.QueryString["id"]);
                string username = string.Empty;
                string author = string.Empty;
                DataSet contentDs = userReg.ArticleDetails(articleId);
                if (contentDs.Tables[0].Rows.Count > 0)
                {
                    ArticleTypehtml = contentDs.Tables[0].Rows[0]["TypeName"].ToString();
                    Titlehtml = contentDs.Tables[0].Rows[0]["Title"].ToString();
                    CreateDatehtml = contentDs.Tables[0].Rows[0]["CreateDate"].ToString();
                    author = contentDs.Tables[0].Rows[0]["UserName"].ToString();
                    Contenthtml = contentDs.Tables[0].Rows[0]["Contents"].ToString();
                    Authorhtml = author;

                    if (Session["user"] != null)
                    {
                        username = Session["user"].ToString();
                        if (username == author)
                        {
                            Updatehtml += "<a href=\"ArticleModify.aspx?id=" + articleId + "\">" + "编辑" + "</a>";
                            Updatehtml += "<a href=\"ArticleModify.aspx?id=" + articleId + "\">" + "删除" + "</a>";
                        }
                        else
                        {
                            Updatehtml = "";
                        }
                    }
                    else
                    {
                        Updatehtml = "";
                    }
                }
                else
                {
                    Response.Redirect("Article.aspx");
                }
            }

        }
    }
}