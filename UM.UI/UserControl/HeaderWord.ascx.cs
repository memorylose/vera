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
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public string HeaderWrodhtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowHeaderWord();
        }

        public void ShowHeaderWord()
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet dsUserSign = userReg.ShowUserSign();
            string Signature = dsUserSign.Tables[0].Rows[0]["Signature"].ToString();
            HeaderWrodhtml += Signature;
        }
    }
}