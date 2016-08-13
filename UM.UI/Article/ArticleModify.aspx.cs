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
    public partial class ArticleModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("../Login.aspx");
                }
                else
                {
                    UserRegisterBusiness userReg = new UserRegisterBusiness();
                    BindTypeDp();
                    DataSet contentDs = userReg.ArticleDetails(Convert.ToInt32(Request.QueryString["id"]));
                    txtTitle.Value = contentDs.Tables[0].Rows[0]["Title"].ToString();
                    txtContent.Value = contentDs.Tables[0].Rows[0]["Contents"].ToString();
                    DropDownList1.SelectedValue = contentDs.Tables[0].Rows[0]["TypeId"].ToString();
                }
            }
        }

        private void BindTypeDp()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet articleTypeDs = userReg.GetArticleType();
            DropDownList1.DataSource = articleTypeDs;
            DropDownList1.DataTextField = "TypeName";
            DropDownList1.DataValueField = "TypeId";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = Session["user"].ToString();

            UserRegisterBusiness userReg = new UserRegisterBusiness();
            int userId = userReg.GetUserId(username);
            int typeId = Convert.ToInt32(DropDownList1.SelectedItem.Value);

            int articleId = Convert.ToInt32(Request.QueryString["id"]);
            string title = txtTitle.Value;
            string content = txtContent.Value;

            int i = userReg.ModifyArticle(title, content, typeId, articleId);
            if (i != 0)
            {
                Response.Redirect("Article.aspx");
            }
            else
            {
                Response.Write("Modify Article Failed, Please Try Again");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            int articleId = Convert.ToInt32(Request.QueryString["id"]);
            int i = userReg.DeleteArticle(articleId);
            if (i != 0)
            {
                Response.Redirect("Article.aspx");
            }
        }
    }
}