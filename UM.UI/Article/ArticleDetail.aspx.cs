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
        public string ArticleTypehtml = "";
        public string Titlehtml = "";
        public string CreateDatehtml = "";
        public string Authorhtml = "";
        public string Updatehtml = "";
        public string Contenthtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //string username = string.Empty;
            //if (Session["user"] == null)
            //{
            //    Response.Redirect("../Login.aspx");
            //}
            //else
            //{
            //    //get user information
            //    username = Session["user"].ToString();
            //}
            //就当现在你访问的是1的文章
            int articleId = Convert.ToInt32(Request.QueryString["id"]);

            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet contentDs = userReg.ArticleDetails(articleId);
            ArticleTypehtml = contentDs.Tables[0].Rows[0]["TypeName"].ToString();
            Titlehtml = contentDs.Tables[0].Rows[0]["Title"].ToString();
            CreateDatehtml = contentDs.Tables[0].Rows[0]["CreateDate"].ToString();     
            Authorhtml = contentDs.Tables[0].Rows[0]["UserName"].ToString();
            if (Session["user"] != null)
            {
                Updatehtml += "<a href=\"ArticleModify.aspx?id=" + articleId + "\">" + "编辑" + "</a>";
                Updatehtml += "<a href=\"ArticleModify.aspx?id=" + articleId + "\">" + "删除" + "</a>";
            }
            else
            {
                Updatehtml = "";
            }
            Contenthtml = contentDs.Tables[0].Rows[0]["Contents"].ToString();
        }
    }
}