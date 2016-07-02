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
            sqlParam[1].Value = EncryptUtil.CreateSHA256HashString(password);

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

        public int AddArticle(string username)
        {
            string getIdSql = "select ID from Users where Username = @username";
            SqlParameter[] sqlParam = {
                new SqlParameter("@username",SqlDbType.NVarChar,20)
            };
            sqlParam[0].Value = username;
            object result = SqlHelper.ExcuteScalar(CommandType.Text, getIdSql, sqlParam);
            int i = Convert.ToInt32(result);
            return i;
        }

        public int AddArticle(string title, string content, int userid)
        {
            string insertSql = "insert into Articles(Title, Contents,CreateDate,CreateUserId) values (@Title,@Contents,@CreateDate,@CreateUserId)";
            SqlParameter[] sqlParam = {
                    new SqlParameter("@Title",SqlDbType.NVarChar,100),
                    new SqlParameter("@Contents",SqlDbType.NVarChar),
                    new SqlParameter("@CreateDate",SqlDbType.DateTime),
                    new SqlParameter("@CreateUserId",SqlDbType.Int)
                };
            sqlParam[0].Value = title;
            sqlParam[1].Value = content;
            sqlParam[2].Value = DateTime.Now;
            sqlParam[3].Value = userid;
            int i = SqlHelper.ExcuteNonQuery(CommandType.Text, insertSql, sqlParam);
            return i;
        }

        public DataSet ShowArticle()
        {
            DataSet dshow = SqlHelper.ExcuteDataSet("select Id,Title,CreateDate from Articles order by CreateDate");
            return dshow;
        }

        public DataSet ArticleDetails(int articleId)
        {
            string sql = "select Title,Contents,CreateDate from Articles where Id=@id";
            SqlParameter[] sqlParam = {
                    new SqlParameter("@id",SqlDbType.Int)
            };
            sqlParam[0].Value = articleId;
            DataSet ds = SqlHelper.ExcuteDataSet(sql, CommandType.Text, sqlParam);
            return ds;
        }
    }
}
