﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UM.BusinessLogic;
using UM.Utility;

namespace UM.UI
{
    public partial class Index : System.Web.UI.Page
    {
        public string Pageheadhtml = "";
        public string RankListhtml = "";
        public string ArticleDetailhtml = "";
        public string ArticleListhtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Pageheadhtml += "<div class=\"header-login\"><a href=\"../Register.aspx\">注册</a></div>";
            Pageheadhtml += "<div class=\"header-login\"><a href=\"../Login.aspx\">登录</a></div>";
            ShowHotArticle();
            ShowArticleList();
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

        public void ShowArticleList()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet ds = userReg.ShowArticle();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int articleId = Convert.ToInt32(ds.Tables[0].Rows[i]["ArticleId"]);
                string title = ds.Tables[0].Rows[i]["Title"].ToString();
                string crDate = ds.Tables[0].Rows[i]["CreateDate"].ToString();
                string crYear = DateTime.Parse(crDate).Year.ToString();
                string crMonth = DateTime.Parse(crDate).Month.ToString();
                string month = ShowMonth(crMonth);
                string crDay = DateTime.Parse(crDate).Day.ToString();
                string typeName = ds.Tables[0].Rows[i]["TypeName"].ToString();
                string summary = ds.Tables[0].Rows[i]["Summary"].ToString();

                if (summary == "")
                {
                    string contents = ds.Tables[0].Rows[i]["Contents"].ToString();
                    contents = System.Text.RegularExpressions.Regex.Replace(contents, RegexConstant.Htmlmark, "");
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
                ArticleListhtml += "<div class=\"r-content-d\">";
                ArticleListhtml += "<div class=\"row row-marginb\">";
                ArticleListhtml += "<div class=\"col-md-1 bt-padding r-time-d\">";
                ArticleListhtml += "<div class=\"r-date-t\">";
                ArticleListhtml += "<div class=\"r-date-year\">" + crYear + "</div>";
                ArticleListhtml += "<div class=\"r-date-month\">" + month + "</div>";
                ArticleListhtml += "</div>";
                ArticleListhtml += "<div class=\"r-date-b\">";
                ArticleListhtml += crDay;
                ArticleListhtml += "</div>";
                ArticleListhtml += "</div>";
                ArticleListhtml += "<div class=\"col-md-10 bt-padding\">";

                ArticleListhtml += "<div class=\"r-title\"><a href=\"Article/ArticleDetail.aspx?id=" + articleId + "\">" + title + "</a></div>";
                ArticleListhtml += "<div class=\"r-time-1\"><a href=\"\">" + typeName + "</a></div>";
                ArticleListhtml += "<div class=\"r-time-1\"><a href=\"Article/ArticleModify.aspx?id=" + articleId + "\">" + "编辑" + "</a></div>";
                ArticleListhtml += "<div class=\"r-time-1\"><a href=\"Article/ArticleModify.aspx?id=" + articleId + "\">" + "删除" + "</a></div>";
                ArticleListhtml += "<div style=\"clear: both\"></div>";
                ArticleListhtml += "<div class=\"r-subject\">" + summary + "</div>";

                ArticleListhtml += "</div>";
                ArticleListhtml += "</div>";
                ArticleListhtml += "</div>";
            }
        }

        public string ShowMonth(string month)
        {
            switch (Convert.ToInt32(month))
            {
                case 1:
                    month = "一";
                    break;
                case 2:
                    month = "二";
                    break;
                case 3:
                    month = "三";
                    break;
                case 4:
                    month = "四";
                    break;
                case 5:
                    month = "五";
                    break;
                case 6:
                    month = "六";
                    break;
                case 7:
                    month = "七";
                    break;
                case 8:
                    month = "八";
                    break;
                case 9:
                    month = "九";
                    break;
                case 10:
                    month = "十";
                    break;
                case 11:
                    month = "十一";
                    break;
                case 12:
                    month = "十二";
                    break;
            }
            return month;
        }
    }
}