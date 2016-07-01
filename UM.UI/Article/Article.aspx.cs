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
        protected void Page_Load(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet titles = userReg.ShowArticle();
            string title = string.Empty;
            for (int i = 0; i < titles.Tables[0].Rows.Count; i++)
            {
                title += titles.Tables[0].Rows[i]["Title"].ToString() + "<br/>";
            }

        }
    }
}