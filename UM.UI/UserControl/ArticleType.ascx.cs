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
    public partial class ArticleType : System.Web.UI.UserControl
    {
        public string ArticleTypeHtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowArticleType();
        }

        public void ShowArticleType()
        {
            string TypeName = string.Empty;
            string TypeId = string.Empty;
            string Count = string.Empty;
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet dsArtType = userReg.ArticleType();

            for (int i = 0; i < dsArtType.Tables[0].Rows.Count; i++)
            {
                TypeName = dsArtType.Tables[0].Rows[i]["TypeName"].ToString();
                TypeId = dsArtType.Tables[0].Rows[i]["TypeId"].ToString();
                Count = dsArtType.Tables[0].Rows[i]["TypeCount"].ToString();
                ArticleTypeHtml += "<div class=\"row bt-margin\">";
                ArticleTypeHtml += "<div class=\"l-cate-name\"><a href=\"\">" + TypeName + "</a></div>";
                ArticleTypeHtml += "<div class=\"l-cate-name-d\">(" + Count + ")</div>";
                ArticleTypeHtml += "</div>";
            }
        }

    }
}
