using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UM.BusinessLogic;
using UM.Utility;

namespace UM.UI.UserControl
{
    public partial class Todo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            DataSet searcharticleDs = userReg.SearchArticle(txtSearch.Value);
            for (int i = 0; i < searcharticleDs.Tables[0].Rows.Count; i++)
            {
                string title = searcharticleDs.Tables[0].Rows[i]["Title"].ToString();
                string crDate = searcharticleDs.Tables[0].Rows[i]["CreateDate"].ToString();
                string typeName = searcharticleDs.Tables[0].Rows[i]["TypeName"].ToString();
                string summary = searcharticleDs.Tables[0].Rows[i]["Summary"].ToString();
                if (summary == "")
                {
                    string contents = searcharticleDs.Tables[0].Rows[i]["Contents"].ToString();
                    contents = System.Text.RegularExpressions.Regex.Replace(contents, RegexConstant.Htmlmark, "");
                    if (contents.Length < 100)
                    {
                        summary = contents;
                    }
                    else
                    {
                        summary = contents.Substring(0, 100);
                        summary = summary.Substring(0, 99) + System.Text.RegularExpressions.Regex.Replace(summary.Substring(99, 1), RegexConstant.AlphaNumber, "");
                        summary += "......";
                    }
                }
            }
            Response.Redirect("Article.aspx?keyword=" + txtSearch.Value);
        }
    }
}