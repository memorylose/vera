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
    public partial class ArticleDetail : System.Web.UI.Page
    {
        public string Contenthtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet contentDs = userReg.ArticleDetails();
            string content = contentDs.Tables[0].Rows[0]["Contents"].ToString();
            for (int i = 0; i < contentDs.Tables[0].Rows.Count; i++)
            {
                Contenthtml += "<div style=\"height: 30px; width: 2200px; text - align: center; font - size: 13px; margin - bottom: 20px; float: left; \">";
                Contenthtml += content;
                Contenthtml += "</div>";
            }
        }
    }
}