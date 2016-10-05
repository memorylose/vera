using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UM.BusinessLogic;

namespace UM.UI.UserControl
{
    public partial class UserInfo : System.Web.UI.UserControl
    {
        public string UserInfoHtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                ShowUserInfo();
            }
        }

        public void ShowUserInfo()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            string username = Session["user"].ToString();
            int userId = userReg.GetUserId(username);
            DataSet dsUserInfo = userReg.ShowUserInfo(userId);
            string Gender = dsUserInfo.Tables[0].Rows[0]["Gender"].ToString();
            string Profession = dsUserInfo.Tables[0].Rows[0]["Profession"].ToString();
            string Major = dsUserInfo.Tables[0].Rows[0]["Major"].ToString();

            UserInfoHtml += "<div class=\"row bt-margin\">";
            UserInfoHtml += "<div class=\"l-detail-name\">姓名：</div>";
            UserInfoHtml += "<div class=\"l-detail-name\">" + username + "</div>";
            UserInfoHtml += "</div>";
            UserInfoHtml += "<div class=\"row bt-margin\">";
            UserInfoHtml += "<div class=\"l-detail-name\">性别：</div>";
            UserInfoHtml += "<div class=\"l-detail-name\">" + Gender + "</div>";
            UserInfoHtml += "</div>";
            UserInfoHtml += "<div class=\"row bt-margin\">";
            UserInfoHtml += "<div class=\"l-detail-name\">职业：</div>";
            UserInfoHtml += "<div class=\"l-detail-name\">" + Profession + "</div>";
            UserInfoHtml += "</div>";
            UserInfoHtml += "<div class=\"row bt-margin\">";
            UserInfoHtml += "<div class=\"l-detail-name\">领域：</div>";
            UserInfoHtml += "<div class=\"l-detail-name\">" + Major + "</div>";
            UserInfoHtml += "</div>";
        }
    }
}