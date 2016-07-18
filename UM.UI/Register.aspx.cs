using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UM.BusinessLogic;

namespace UM.UI
{
    public partial class Register : System.Web.UI.Page
    {
        public string RegisterErrorMessageshtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            string validateResult = userReg.RegisterValidation(txtUsername.Value.Trim(), txtNickname.Value, txtPassword.Value.Trim(), txtConfirmPassword.Value.Trim(), txtMail.Value.Trim());

            if (string.IsNullOrEmpty(validateResult))
            {
                int i = userReg.CheckUserExist(txtUsername.Value.Trim());
                if (i > 0)
                {
                    RegisterErrorMessageshtml += "Username already exists,please register again";
                }
                else
                {
                    userReg.CreateUser(txtUsername.Value.Trim(), txtNickname.Value, txtPassword.Value.Trim(), txtMail.Value.Trim());
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                RegisterErrorMessageshtml += validateResult;
            }
        }
    }
}