using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UM.UI.UserControl
{
    public partial class Footer : System.Web.UI.UserControl
    {
        public string Footerhtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Footerhtml += "营业执照注册号：210204000071792 备案号：辽ICP备14012672号-1 ©2014 jiangyingrui.com,All Rights Reserved.";
        }
    }
}