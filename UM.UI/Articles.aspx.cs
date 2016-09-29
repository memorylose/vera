using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UM.BusinessLogic;

namespace UM.UI
{
    public partial class Articles : System.Web.UI.Page
    {
        public string RankListhtml = "";
        public string Pageheadhtml = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Pageheadhtml += "<div class=\"header-login\"><a href=\"../Register.aspx\">注册</a></div>";
            Pageheadhtml += "<div class=\"header-login\"><a href=\"../Login.aspx\">登录</a></div>";
            ShowHotArticle();
        }

        public void ShowHotArticle()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet ds = userReg.HotArticle();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string title = ds.Tables[0].Rows[i]["Title"].ToString();
                if (title.Length >= 17)
                {
                    title = title.Substring(0, 16);
                    title += "...";
                }
                RankListhtml += "<div class=\"row bt-margin\">";
                RankListhtml += "<div class=\"l-read-name\"><a href=\"ArticleDetail.aspx?id=" + Convert.ToInt32(ds.Tables[0].Rows[i]["ArticleId"]) + "\">" + title + "</a></div>";
                RankListhtml += "<div class=\"l-read-name-d\">(239)</div>";
                RankListhtml += "</div>";
            }
        }
    }
}