﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UM.DataAccess;
using UM.Utility;

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
        public string RegisterValidation(string username, string nickname, string password, string confirmpassword, string mail)
        {

            string errMsg = string.Empty;
            bool vu = ValidateUsername(username);
            bool vp = ValidatePassword(password);
            bool ve = ValidateEmail(mail);

            if (string.IsNullOrEmpty(username))
            {
                errMsg = "Username is empty.";
            }
            else if (string.IsNullOrEmpty(nickname))
            {
                errMsg = "Nickname is empty.";
            }
            else if (string.IsNullOrEmpty(password))
            {
                errMsg = "Password is empty.";
            }
            else if (string.IsNullOrEmpty(confirmpassword))
            {
                errMsg = "Password confirmation is empty.";
            }
            else if (password != confirmpassword)
            {
                errMsg = "Passwords you entered two times are not match.";
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
            Regex regex = new Regex(RegexConstant.UserName);
            return regex.IsMatch(username);
        }

        public bool ValidatePassword(string password)
        {
            Regex regex = new Regex(RegexConstant.Password);
            return regex.IsMatch(password);
        }

        public bool ValidateEmail(string email)
        {
            Regex regex = new Regex(RegexConstant.Email);
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

        public void CreateUser(string username, string nickname, string password, string mail)
        {
            UserRegisterData userReg = new UserRegisterData();
            userReg.CreateUser(username, nickname, password, mail);
        }

        public int UserLogin(string username, string password)
        {
            UserRegisterData userReg = new UserRegisterData();
            int i = userReg.UserLogin(username, password);
            return i;
        }

        public DataSet GetUserNickname(string username)
        {
            UserRegisterData userReg = new UserRegisterData();
            DataSet ds = userReg.GetUserNickname(username);
            return ds;
        }

        public int GetUserId(string username)
        {
            UserRegisterData userReg = new UserRegisterData();
            int i = userReg.GetUserId(username);
            return i;
        }

        public int AddArticle(string title, string summary, string content, int id, int typeId)
        {
            UserRegisterData userReg = new UserRegisterData();
            int i = userReg.AddArticle(title, summary, content, id, typeId);
            return i;
        }

        public int ModifyArticle(string title, string content, int typeId, int articleId)
        {
            UserRegisterData userReg = new UserRegisterData();
            int i = userReg.ModifyArticle(title, content, typeId, articleId);
            return i;
        }

        public DataSet ShowArticle()
        {
            UserRegisterData userReg = new UserRegisterData();
            DataSet titles = userReg.ShowArticle();
            return titles;
        }

        public DataSet ShowArticle(int userid)
        {
            UserRegisterData userReg = new UserRegisterData();
            DataSet titles = userReg.ShowArticle(userid);
            return titles;
        }

        public DataSet ArticleDetails(object articleId)
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

        public DataSet GetArticleTypeId(string type)
        {
            UserRegisterData userReg = new UserRegisterData();
            DataSet ds = userReg.GetArticleTypeId(type);
            return ds;
        }

        public bool ValidateArticleId(object articleId)
        {
            Regex regex = new Regex(RegexConstant.ArticleId);
            return regex.IsMatch(articleId.ToString());
        }
    }
}
