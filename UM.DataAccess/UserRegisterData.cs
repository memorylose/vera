using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UM.Utility;

namespace UM.DataAccess
{
    public class UserRegisterData
    {
        public void CreateUser(string username, string password, string mail)
        {
            string sqlStr = "INSERT INTO Users(Username,Password,Email,CreateDate,UpdateDate) VALUES (@Username,@Password,@Email,@CreateDate,@UpdateDate)";
            SqlParameter[] sqlParam = {
                    new SqlParameter("@Username",SqlDbType.NVarChar,20),
                    new SqlParameter("@Password",SqlDbType.NVarChar,50),
                    new SqlParameter("@Email",SqlDbType.NVarChar,20),
                    new SqlParameter("@CreateDate",SqlDbType.DateTime),
                    new SqlParameter("@UpdateDate",SqlDbType.DateTime)
                };
            sqlParam[0].Value = username;
            sqlParam[1].Value = EncryptUtil.CreateSHA256HashString(password);
            sqlParam[2].Value = mail;
            sqlParam[3].Value = DateTime.Now;
            sqlParam[4].Value = DateTime.Now;

            SqlHelper.ExcuteNonQuery(CommandType.Text, sqlStr, sqlParam);
        }

        public int UserLogin(string username, string password)
        {
            string sqlStr = "select count(*) from Users where Username = @username and Password = @password";
            SqlParameter[] sqlParam = {
                    new SqlParameter("@Username",SqlDbType.NVarChar,20),
                    new SqlParameter("@Password",SqlDbType.NVarChar,50)
                };
            sqlParam[0].Value = username;
            sqlParam[1].Value = password;
            
            object result = SqlHelper.ExcuteScalar(CommandType.Text, sqlStr, sqlParam);
            int i = Convert.ToInt32(result);
            return i;
        }

        public int CheckUserExist(string username)
        {
            string sqlStr = "select count(*) from Users where Username=@username";
            SqlParameter[] sqlParam = {
                new SqlParameter("@username",SqlDbType.NVarChar,20)
            };
            sqlParam[0].Value = username;
            object result = SqlHelper.ExcuteScalar(CommandType.Text, sqlStr, sqlParam);
            int i = Convert.ToInt32(result);
            return i;
        }
    }
}
