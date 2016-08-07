using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UM.BusinessLogic;
using UM.Utility;

namespace UM.UI.UserControl
{
    public partial class Todo : System.Web.UI.UserControl
    {
        public string HotArticlehtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet ds = userReg.HotArticle();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                HotArticlehtml += "<div class=\"right-t\">";
                HotArticlehtml += "<div class=\"right-num\">" + (i + 1).ToString().PadLeft(2, '0') + "</div>";
                HotArticlehtml += "<div class=\"right-con\"><a href=\"ArticleDetail.aspx?id=" + Convert.ToInt32(ds.Tables[0].Rows[i]["ArticleId"]) + "\">" + ds.Tables[0].Rows[i]["Title"].ToString() + "</a></div>";
                HotArticlehtml += "</div>";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Value;
            Response.Redirect("Article.aspx?keyword=" + keyword);
        }
    }
}