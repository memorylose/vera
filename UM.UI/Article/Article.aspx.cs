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
                Articlehtml += "" + "< div style = " + "\""+"height: 30px; text - align: center; font - size: 20px; margin - bottom: 20px; "+"\"" + ">" + "<br/>";
                Articlehtml += "" + articleDs.Tables[0].Rows[i]["Title"].ToString() + "<br/>";
                Articlehtml += "" + "</ div >";
            }
        }
    }
}