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

        public string Titlehtml = "";
        public string Contenthtml = "";
        public string Timehtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //就当现在你访问的是1的文章
            int articleId = Convert.ToInt32(Request.QueryString["id"]);

            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet contentDs = userReg.ArticleDetails(articleId);
            string title = contentDs.Tables[0].Rows[0]["Title"].ToString();
            string content = contentDs.Tables[0].Rows[0]["Contents"].ToString();
            string crDate = contentDs.Tables[0].Rows[0]["CreateDate"].ToString();
            Titlehtml += title + "<br/>";
            Contenthtml += content + "<br/>";
            Timehtml += crDate;
        }
    }
}