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
    public partial class Login : System.Web.UI.Page
    {
        public string LoginErrorMessageshtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            //Go to home.aspx when succeed
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            string validateResult = userReg.LoginValidation(txtUsername.Value, txtPassword.Value);
            if (string.IsNullOrEmpty(validateResult))
            {
                int i = userReg.UserLogin(txtUsername.Value, txtPassword.Value);
                if (i > 0)
                {
                    //use session to save the user information
                    Session["user"] = txtUsername.Value;
                    Response.Redirect("Article/Article.aspx");
                }
                else
                {
                    LoginErrorMessageshtml += "<div class=\"row\">" + "<br/>";
                    LoginErrorMessageshtml += "<div class=\"login_err\">Username or Password is not correct, please check and login again</div>" + "<br/>";
                    LoginErrorMessageshtml += "</div> ";
                }
            }
            else
            {
                LoginErrorMessageshtml += "<div class=\"row\">" + "<br/>";
                LoginErrorMessageshtml += "<div class=\"login_err\">" + validateResult + "</div>" + "<br/>";
                LoginErrorMessageshtml += "</div> ";
            }
        }
    }
}