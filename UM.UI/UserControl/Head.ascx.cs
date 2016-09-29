using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UM.UI.UserControl
{
    public partial class Head1 : System.Web.UI.Page
    {
        public string Pageheadhtml = "";
        public string Headerhtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowPageHead();
            ShowHeader();
        }

        public void ShowPageHead()
        {
            Pageheadhtml += "<div class=\"header-login\"><a href=\"Register.aspx\">注册</a></div>";
            Pageheadhtml += "<div class=\"header-login\"><a href=\"Login.aspx\">登录</a></div>";
        }

        public void ShowHeader()
        {
            Headerhtml += "It is said that you will appear in the dreams of others when you fail to fall asleep.";
        }
    }
}