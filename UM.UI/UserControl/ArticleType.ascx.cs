using System;
using System.Data;
using UM.BusinessLogic;

namespace UM.UI.UserControl
{
    public partial class ArticleType : System.Web.UI.UserControl
    {
        public string ArticleTypeHtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowArticleType();
        }

        private void ShowArticleType()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet dsArtType = userReg.ArticleType();
            for (int i = 0; i < dsArtType.Tables[0].Rows.Count; i++)
            {
                ArticleTypeHtml += "<div class=\"row bt-margin\">";
                ArticleTypeHtml += "<div class=\"l-cate-name\"><a href=\"\">" + dsArtType.Tables[0].Rows[i]["TypeName"].ToString() + "</a></div>";
                ArticleTypeHtml += "<div class=\"l-cate-name-d\">(" + dsArtType.Tables[0].Rows[i]["TypeCount"].ToString() + ")</div>";
                ArticleTypeHtml += "</div>";
            }
        }
    }
}
