﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UM.UI.UserControl
{
    public partial class BlogName : System.Web.UI.UserControl
    {
        public string BlogNameHtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            BlogNameHtml+= "<a href=\"Index.aspx\"><img src=\"/images/logo.png\" class=\"header-img \"/></a>";
        }
    }
}