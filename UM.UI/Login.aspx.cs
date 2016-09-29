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
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            string validateResult = userReg.LoginValidation(txtUsername.Value.Trim(), txtPassword.Value);
            if (string.IsNullOrEmpty(validateResult))
            {
                //验证码是以cookie的形式存在客户端，而浏览器是可以禁止cookie的，所以如果浏览器禁用cookie那么验证码就用不了了，所以需要先判断验证码是否正确生成了
                if (Request.Cookies["CheckCode"] == null)
                {
                    LoginErrorMessageshtml += "您的浏览器设置已被禁用 Cookies，您必须设置浏览器允许使用 Cookies 选项后才能使用本系统。";
                }
                else
                {
                    //判断验证码是否为空并且是否相等
                    if (!string.IsNullOrEmpty(txtVerify.Value) && string.Equals(txtVerify.Value.ToUpper(), Request.Cookies["CheckCode"].Value.ToUpper()))
                    {
                        //判断用户名密码
                        int i = userReg.UserLogin(txtUsername.Value.Trim(), txtPassword.Value);
                        if (i > 0)
                        {
                            Session["user"] = txtUsername.Value;
                            Response.Redirect("Index.aspx");//Article/Article
                        }
                        else
                        {
                            LoginErrorMessageshtml += "用户名密码错误";
                        }
                    }
                    else
                    {
                        LoginErrorMessageshtml += "验证码错误";
                    }
                }
            }
            else
            {
                LoginErrorMessageshtml += validateResult;
            }
        }
    }
}