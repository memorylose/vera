using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UM.UI.UserControl
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public string HeaderWrodhtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowHeaderWord();
        }

        public void ShowHeaderWord()
        {
            HeaderWrodhtml += "It is said that you will appear in the dreams of others when you fail to fall asleep.";
        }
    }
}