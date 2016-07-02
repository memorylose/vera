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
        protected void Page_Load(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet contentDs = userReg.ArticleDetails();
            string content = contentDs.Tables[0].Rows[0]["Contents"].ToString();
            Response.Write(content);
        }
    }
}