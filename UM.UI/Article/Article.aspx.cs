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
        public string ArticlesHtml;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet articleDs = userReg.ShowArticle();
            string title = string.Empty;
            for (int i = 0; i < articleDs.Tables[0].Rows.Count; i++)
            {
                ArticlesHtml += "<div style=\"height: 30px; text-align: center; font-size: 20px; margin-bottom: 20px;\">";
                ArticlesHtml += "" + articleDs.Tables[0].Rows[i]["Title"].ToString() + "";
                ArticlesHtml += "</div>";
            }
        }
    }
}