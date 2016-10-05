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
        public string TitleHtml = "";
        public string CrDateHtml = "";
        public string TypeHtml = "";
        public string ContentHtml = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowArticleDetail();
        }

        /// <summary>
        /// show artcile detail
        /// </summary>
        private void ShowArticleDetail()
        {
            bool isSuc = true;
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            if (Request.QueryString["id"] != null && !userReg.ValidateArticleId(Request.QueryString["id"]))
            {
                isSuc = false;
            }
            else
            {
                int articleId = Convert.ToInt32(Request.QueryString["id"]);
                DataSet dsArtDetail = userReg.ArticleDetails(articleId);
                if (dsArtDetail.Tables[0].Rows.Count > 0)
                {
                    TitleHtml += dsArtDetail.Tables[0].Rows[0]["Title"].ToString();
                    CrDateHtml += dsArtDetail.Tables[0].Rows[0]["CreateDate"].ToString();
                    TypeHtml += dsArtDetail.Tables[0].Rows[0]["TypeName"].ToString();
                    ContentHtml += dsArtDetail.Tables[0].Rows[0]["Contents"].ToString();
                }
                else
                {
                    isSuc = false;
                }
            }

            if (!isSuc)
                Response.Redirect("Index.aspx");
        }
    }
}