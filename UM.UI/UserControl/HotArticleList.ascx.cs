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
    public partial class HotArticleList : System.Web.UI.UserControl
    {
        public string RankListhtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowHotArticle();
        }

        private void ShowHotArticle()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet ds = userReg.HotArticle();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string title = ds.Tables[0].Rows[i]["Title"].ToString();
                if (title.Length >= 15)
                    title = title.Substring(0, 15) + "...";
                RankListhtml += "<div class=\"row bt-margin\">";
                RankListhtml += "<div class=\"l-read-name\"><a href=\"Articles.aspx?id=" + Convert.ToInt32(ds.Tables[0].Rows[i]["ArticleId"]) + "\">" + title + "</a></div>";
                RankListhtml += "<div class=\"l-read-name-d\">(239)</div>";
                RankListhtml += "</div>";
            }
        }
    }
}