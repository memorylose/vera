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
                BindDropdownList();
                int articleId = Convert.ToInt32(Request.QueryString["id"]);
                UserRegisterBusiness userReg = new UserRegisterBusiness();
                DataSet contentDs = userReg.ArticleDetails(articleId);
                txtTitle.Value = contentDs.Tables[0].Rows[0]["Title"].ToString();
                txtContent.Value = contentDs.Tables[0].Rows[0]["Contents"].ToString();
            }
        }

        private void BindDropdownList()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet articleTypeDs = userReg.GetArticleType();
            DropDownList1.DataSource = articleTypeDs;
            DropDownList1.DataTextField = "TypeName";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = string.Empty;
            if (Session["user"] != null)
            {
                username = Session["user"].ToString();
            }
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            int userId = userReg.GetUserId(username);
            string dpValue = DropDownList1.SelectedItem.Value;
            DataSet ds = userReg.GetArticleId(dpValue);
            int typeId = 0;
            for (int n = 0; n < ds.Tables[0].Rows.Count; n++)
            {
                typeId = Convert.ToInt32(ds.Tables[0].Rows[n]["Id"].ToString());
            }
            int articleId = Convert.ToInt32(Request.QueryString["id"]);
            string title = txtTitle.Value;
            string content = txtContent.Value;
            int i = userReg.ArticleModify(title, content, typeId, articleId);
            if (i != 0)
            {
                Response.Redirect("Article.aspx");
            }
            else
            {
                Response.Write("Add Article Failed, Please Try Again");
            }
        }
    }
}