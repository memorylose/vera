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
    public partial class AddArticle : System.Web.UI.Page
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
                    BindDropdownList();
                }
            }
        }

        private void BindDropdownList()
        {
            //TODO: Create new table(ArticleType), id,name(nvarchar10)
            //TODO: get dataset for article type

            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet articleTypeDs = userReg.GetArticleType();
            DropDownList1.DataSource = articleTypeDs;
            DropDownList1.DataTextField = "TypeName";
            DropDownList1.DataBind();
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            string username = string.Empty;

            //get user information
            if (Session["user"] != null)
            {
                username = Session["user"].ToString();
            }

            UserRegisterBusiness userReg = new UserRegisterBusiness();
            int userId = userReg.AddArticle(username);
            string dpValue = DropDownList1.SelectedItem.Value;
            DataSet ds=userReg.GetArticleId(dpValue);
            int typeId = 0;
            for (int n = 0; n < ds.Tables[0].Rows.Count; n++)
            {
                typeId = Convert.ToInt32(ds.Tables[0].Rows[n]["Id"].ToString());
            }
            int i = userReg.AddArticle(txtTitle.Value, txtContent.Value, userId, typeId);
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