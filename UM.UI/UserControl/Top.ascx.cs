using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UM.UI.UserControl
{
    public partial class Top : System.Web.UI.UserControl
    {
        public string Pageheadhtml = "";
        public string Pagehtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Pageheadhtml += "Welcome to Blog";
            if (Session["user"] == null)
            {
                Pagehtml += "<div class=\"top-login\"><a href=\"../Login.aspx\">登录</a></div>";
                Pagehtml += "<div class=\"top-login\"><a href=\"../Register.aspx\">注册</a></div>";
            }
            else
            {
                Pagehtml += "<div class=\"top-login\"><a href=\"../LogOut.aspx\">退出</a></div>";
            }
        }
    }
}