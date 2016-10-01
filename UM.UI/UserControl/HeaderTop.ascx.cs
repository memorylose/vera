using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UM.UI.UserControl
{
    public partial class HeaderTop : System.Web.UI.UserControl
    {
        public string HeaderTophtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowHeaderTop();
        }

        public void ShowHeaderTop()
        {
            HeaderTophtml += "<div class=\"header-login\"><a href=\"Register.aspx\">注册</a></div>";
            HeaderTophtml += "<div class=\"header-login\"><a href=\"Login.aspx\">登录</a></div>";
        }
    }
}