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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            string validateResult = userReg.RegisterValidation(txtUsername.Value, txtPassword.Value, txtMail.Value);

            if (string.IsNullOrEmpty(validateResult))
            {
                int i = userReg.CheckUserExist(txtUsername.Value);
                if (i > 0)
                {
                    Response.Write("Username already exists,please register again");
                }
                else 
                {
                    userReg.CreateUser(txtUsername.Value, txtPassword.Value, txtMail.Value);
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Response.Write(validateResult);
            }
        }
    }
}