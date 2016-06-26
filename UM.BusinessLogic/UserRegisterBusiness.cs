using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UM.DataAccess;

namespace UM.BusinessLogic
{
    public class UserRegisterBusiness
    {
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
            return errMsg;

        }

        public void CreateUser(string username, string password, string mail)
        {
            UserRegisterData userReg = new UserRegisterData();
            userReg.CreateUser(username, password, mail);
        }
    }
}
