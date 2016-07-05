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
                //TODO 这个页面也是需要登录访问的，没有判断
                if (Session["user"] == null)
                {
                    Response.Redirect("../Login.aspx");
                }
                else
                {
                    //
                }
                int articleId = Convert.ToInt32(Request.QueryString["id"]);
                UserRegisterBusiness userReg = new UserRegisterBusiness();
                DataSet contentDs = userReg.ArticleDetails(articleId);
                txtTitle.Value = contentDs.Tables[0].Rows[0]["Title"].ToString();
                txtContent.Value = contentDs.Tables[0].Rows[0]["Contents"].ToString();

                //TODO dropdown的赋值没有，没有直接显示出来这篇文章是什么类别的
                
                DataSet articleTypeDs = userReg.GetArticleType();
                DropDownList1.DataSource = articleTypeDs;
                DropDownList1.DataTextField = "TypeName";
                DropDownList1.DataBind();

                DataSet articleType = userReg.GetArticleType(articleId);
                string typeName = string.Empty;
                for (int n = 0; n < articleType.Tables[0].Rows.Count; n++)
                {
                   typeName = articleType.Tables[0].Rows[n]["TypeName"].ToString();
                }
                DropDownList1.SelectedValue = typeName;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = Session["user"].ToString();

            UserRegisterBusiness userReg = new UserRegisterBusiness();
            int userId = userReg.GetUserId(username);
            string dpValue = DropDownList1.SelectedItem.Value;

            //TODO: 这块没有必须再取一遍ID，既然能把dropdownlist的value取出来，那么你觉得能不能直接把ID取出来？
            //DataSet ds = userReg.GetArticleId(dpValue);
            //int typeId = 0;
            //for (int n = 0; n < ds.Tables[0].Rows.Count; n++)
            //{
            //    typeId = Convert.ToInt32(ds.Tables[0].Rows[n]["Id"].ToString());
            //}

            int articleId = Convert.ToInt32(Request.QueryString["id"]);
            string title = txtTitle.Value;
            string content = txtContent.Value;

            //TODO: 方法的命名永远都是动宾
            int i = userReg.ModifyArticle(title, content, dpValue, articleId);
            if (i != 0)
            {
                Response.Redirect("Article.aspx");
            }
            else
            {
                //TODO: 又成add了？
                Response.Write("Modify Article Failed, Please Try Again");
            }
        }
    }
}