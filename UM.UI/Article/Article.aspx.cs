using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UM.BusinessLogic;
using UM.Utility;

namespace UM.UI.Article
{
    public partial class Article : System.Web.UI.Page
    {
        public string Articleshtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            int articleId = 0;
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
                    //summary = allarticleDs.Tables[0].Rows[i]["Contents"].ToString().Substring(0, 100);
                    string contents = allarticleDs.Tables[0].Rows[i]["Contents"].ToString();
                    contents = System.Text.RegularExpressions.Regex.Replace(contents, "<[^>]*>", "");
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

                Articleshtml += "<div class=\"row\">";
                Articleshtml += "<div class=\"col-md-12 content-title\"><a href=\"ArticleDetail.aspx?id=" + articleId + "\">" + title + "</a></div>";
                Articleshtml += "<div class=\"col-md-12 content-date\"><span>" + crDate + "</span><span>-</span><span>" + typeName + "</span></div>";
                Articleshtml += "<div class=\"col-md-12 content-t\">" + summary;
                Articleshtml += "</div>";
                Articleshtml += "</div>";
            }
        }
    }
}
