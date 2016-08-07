﻿using System;
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
            string title = "";
            int articleId = 0;
            string a = "";
            for (int i = 1; i <= ds.Tables[0].Rows.Count; i++)
            {
                title = ds.Tables[0].Rows[i-1]["Title"].ToString();
                articleId = Convert.ToInt32(ds.Tables[0].Rows[i-1]["ArticleId"]);
                
                HotArticlehtml += "<div class=\"right-t\">";
                HotArticlehtml += a;
                HotArticlehtml += "<div class=\"right-con\"><a href=\"ArticleDetail.aspx?id=" + articleId + "\">" + title + "</a></div>";
                HotArticlehtml += "</div>";

                if (i < ds.Tables[0].Rows.Count)
                {
                    a = "<div class=\"right-num\">0" + i + ".</div>";
                }
                else
                {
                    a += "<div class=\"right-num\">10.</div>";
                }
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Value;
            Response.Redirect("Article.aspx?keyword=" + keyword);
        }
    }
}