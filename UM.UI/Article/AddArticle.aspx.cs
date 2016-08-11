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
        public string AddErrorMessageshtml = "";
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
                //BindDropdownList();
            }
        }

        private void BindDropdownList()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet articleTypeDs = userReg.GetArticleType();
            DropDownList1.DataSource = articleTypeDs;
            DropDownList1.DataTextField = "TypeName";
            DropDownList1.DataValueField = "TypeId";
            DropDownList1.DataBind();
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            string username = string.Empty;

            //get user information
            if (Session["user"] != null)
            {
                username = Session["user"].ToString();
                UserRegisterBusiness userReg = new UserRegisterBusiness();
                string validateResult = userReg.AddArticleValidation(txtTitle.Value, Request["content"].ToString());
                if (string.IsNullOrEmpty(validateResult))
                {
                    int userId = userReg.GetUserId(username);
                    int typeId = Convert.ToInt32(DropDownList1.SelectedValue);
                    int i = userReg.AddArticle(txtTitle.Value, txtSummary.Value, Request["content"].ToString(), userId, typeId);
                    if (i != 0)
                    {
                        Response.Redirect("Article.aspx");
                    }
                    else
                    {
                        AddErrorMessageshtml += validateResult;
                    }
                }
            }
            else
            {
                Response.Redirect("../Login.aspx");
            }
        }
    }
}