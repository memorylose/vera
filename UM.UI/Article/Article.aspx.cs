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
        public string Articlehtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet articleDs = userReg.ShowArticle();
            for (int i = 0; i < articleDs.Tables[0].Rows.Count; i++)
            {
                Articlehtml += "<div style=\"height: 30px; \">";
                Articlehtml += "<div style=\"height: 30px; width: 500px; text - align: center; font - size: 13px; margin - bottom: 20px; float: left; \">" + "<br/>";
                Articlehtml+= "<a href=\"ArticleDetail.aspx?id=1\">";
                Articlehtml += articleDs.Tables[0].Rows[i]["Title"].ToString();
                Articlehtml += "</a>" + "<br/>";
                Articlehtml += "</div>" + "<br/>";
                Articlehtml += "<div style=\"height: 30px; text - align: center; font - size: 13px; margin - bottom: 20px; float: left; margin - left: 20px; \">" + "<br/>";
                Articlehtml += articleDs.Tables[0].Rows[i]["CreateDate"].ToString() + "<br/>";
                Articlehtml += "</div>" + "<br/>";
                Articlehtml += "</div>";
            }
        }
    }
}