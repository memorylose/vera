﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UM.UI.UserControl
{
    public partial class Todo : System.Web.UI.UserControl
    {
        public string Todohtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Todohtml += "Todo";
        }
    }
}