using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UM.BusinessLogic;
using UM.Utility;

namespace UM.Pager
{
    public class PageDevision : System.Web.UI.Page
    {
        public StringBuilder DevidePage(int pageSize, string request, string link, out int beginRowNumber, out int endRowNumber)
        {
            UserRegisterBusiness userReg = new UserRegisterBusiness();
            StringBuilder PageDevisionhtml = new StringBuilder();
            int articelNumber = userReg.CountNumber();
            int pageNumber = 0;
            int curPage = 0;
            int prePage = 0;
            int nextPage = 0;
            int x = articelNumber % pageSize;
            if (x > 0)
            {
                pageNumber = articelNumber / pageSize + 1;
            }
            else if (x == 0)
            {
                pageNumber = articelNumber / pageSize;
            }

            if (request != null && userReg.ValidatePageId(request))
            {
                curPage = Convert.ToInt32(request);
                if (curPage == 1 && curPage == pageNumber)
                {
                    prePage = curPage;
                    nextPage = curPage;
                }
                else if (curPage == 1 && curPage != pageNumber)
                {
                    prePage = curPage;
                    nextPage = curPage + 1;
                }
                else if (curPage != 1 && curPage == pageNumber)
                {
                    prePage = curPage - 1;
                    nextPage = curPage;
                }
                else
                {
                    prePage = curPage - 1;
                    nextPage = curPage + 1;
                }
            }
            else
            {
                curPage = 1;
                prePage = curPage;
                if (pageNumber > 1)
                {
                    nextPage = curPage + 1;
                }
                else
                {
                    nextPage = curPage;
                }
            }

            PageDevisionhtml.Append(link + prePage.ToString() + "\">上一页</a>");
            for (int j = 1; j <= pageNumber; j++)
            {
                PageDevisionhtml.Append(link + j.ToString() + "\">" + j.ToString() + "</a>");
            }
            PageDevisionhtml.Append(link + nextPage.ToString() + "\">下一页</a>");

            beginRowNumber = (curPage - 1) * pageSize + 1;
            endRowNumber = curPage * pageSize;

            return PageDevisionhtml;             
        }
    }
}
