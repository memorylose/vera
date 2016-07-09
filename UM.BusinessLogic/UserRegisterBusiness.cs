using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UM.DataAccess;

namespace UM.BusinessLogic
{
    public class UserRegisterBusiness
    {
        public object Response { get; private set; }

        /// <summary>
        /// NEED MORE VALIDATION HERE SUCH AS MAIL FORMAT AND PASSWORD FORMAT.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="mail"></param>
        /// <returns></returns>
        public string RegisterValidation(string username, string password, string mail)
        {

            string errMsg = string.Empty;
            bool vu = ValidateUsername(username);
            bool vp = ValidatePassword(password);
            bool ve = ValidateEmail(mail);

            if (string.IsNullOrEmpty(username))
            {
                errMsg = "User name is empty.";
            }
            else if (string.IsNullOrEmpty(password))
            {
                errMsg = "Password is empty.";
            }
            else if (string.IsNullOrEmpty(mail))
            {
                errMsg = "Email is empty.";
            }
            else if (vu == false)
            {
                errMsg = "Username format is not correct";
            }
            else if (vp == false)
            {
                errMsg = "Password format is not correct";
            }
            else if (ve == false)
            {
                errMsg = "Email format is not correct";
            }
            return errMsg;
        }

        public bool ValidateUsername(string username)
        {
            Regex regex = new Regex(@"^\w{6,20}$");
            return regex.IsMatch(username);
        }

        public bool ValidatePassword(string password)
        {
            Regex regex = new Regex(@"^[A-Za-z]\w{5,49}$");
            return regex.IsMatch(password);
        }

        public bool ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            return regex.IsMatch(email);
        }


        public int CheckUserExist(string username)
        {
            UserRegisterData userReg = new UserRegisterData();
            int i = userReg.CheckUserExist(username);
            return i;
        }

        public string LoginValidation(string username, string password)
        {
            string errMsg = string.Empty;

            if (string.IsNullOrEmpty(username))
            {
                errMsg = "User name is empty.";
            }
            else if (string.IsNullOrEmpty(password))
            {
                errMsg = "Password is empty.";
            }
            return errMsg;

        }

        public void CreateUser(string username, string password, string mail)
        {
            UserRegisterData userReg = new UserRegisterData();
            userReg.CreateUser(username, password, mail);
        }

        public int UserLogin(string username, string password)
        {
            UserRegisterData userReg = new UserRegisterData();
            int i = userReg.UserLogin(username, password);
            return i;
        }

        public int GetUserId(string username)
        {
            UserRegisterData userReg = new UserRegisterData();
            int i = userReg.GetUserId(username);
            return i;
        }

        public int AddArticle(string title, string content, int id, int typeId)
        {
            UserRegisterData userReg = new UserRegisterData();
            int i = userReg.AddArticle(title, content, id, typeId);
            return i;
        }

        public int ModifyArticle(string title, string content, int typeId, int articleId)
        {
            UserRegisterData userReg = new UserRegisterData();
            int i = userReg.ModifyArticle(title, content, typeId, articleId);
            return i;
        }

        public DataSet ShowArticle(int userid)
        {
            UserRegisterData userReg = new UserRegisterData();
            DataSet titles = userReg.ShowArticle(userid);
            return titles;
        }

        public DataSet ArticleDetails(int articleId)
        {
            UserRegisterData userReg = new UserRegisterData();
            DataSet ds = userReg.ArticleDetails(articleId);
            return ds;
        }

        public DataSet GetArticleType()
        {
            UserRegisterData userReg = new UserRegisterData();
            DataSet ds = userReg.GetArticleType();
            return ds;
        }

        public DataSet GetArticleId(string type)
        {
            UserRegisterData userReg = new UserRegisterData();
            DataSet ds = userReg.GetArticleId(type);
            return ds;
        }
    }
}
