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
            if (Session["user"] == null)
            {
                Response.Redirect("../Login.aspx");
            }
            else
            {
                BindDropdownList();
            }
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
            int i = userReg.AddArticle(txtTitle.Value, txtContent.Value, userId);
            if (i != 0)
            {
                Response.Redirect("Article.aspx");
            }
            else
            {
                Response.Write("Add Article Failed, Please Try Again");
            }
        }

        private void BindDropdownList()
        {
            //TODO: get dataset for article type
            DataSet articleTypeDs = null;
            DropDownList1.DataSource = articleTypeDs;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataBind();
        }
    }
}