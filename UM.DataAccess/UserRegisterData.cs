﻿using System;
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
            string sqlStr = "INSERT INTO Users(UserName,Password,Email,CreateDate,UpdateDate) VALUES (@Username,@Password,@Email,@CreateDate,@UpdateDate)";
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
            string sqlStr = "select count(*) from Users where UserName = @username and Password = @password";
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
            string sqlStr = "select count(*) from Users where UserName=@username";
            SqlParameter[] sqlParam = {
                new SqlParameter("@username",SqlDbType.NVarChar,20)
            };
            sqlParam[0].Value = username;
            object result = SqlHelper.ExcuteScalar(CommandType.Text, sqlStr, sqlParam);
            int i = Convert.ToInt32(result);
            return i;
        }

        public int GetUserId(string username)
        {
            string getIdSql = "select UserId from Users where UserName = @username";
            SqlParameter[] sqlParam = {
                new SqlParameter("@username",SqlDbType.NVarChar,20)
            };
            sqlParam[0].Value = username;
            object result = SqlHelper.ExcuteScalar(CommandType.Text, getIdSql, sqlParam);
            int i = Convert.ToInt32(result);
            return i;
        }

        public int AddArticle(string title, string content, int userid, int typeId)
        {
            string insertSql = "insert into Articles(Title, Contents,CreateDate,CreateUserId,TypeId) values (@Title,@Contents,@CreateDate,@CreateUserId,@TypeId)";
            SqlParameter[] sqlParam = {
                    new SqlParameter("@Title",SqlDbType.NVarChar,100),
                    new SqlParameter("@Contents",SqlDbType.NVarChar),
                    new SqlParameter("@CreateDate",SqlDbType.DateTime),
                    new SqlParameter("@CreateUserId",SqlDbType.Int),
                    new SqlParameter("@TypeId",SqlDbType.Int)
                };
            sqlParam[0].Value = title;
            sqlParam[1].Value = content;
            sqlParam[2].Value = DateTime.Now;
            sqlParam[3].Value = userid;
            sqlParam[4].Value = typeId;
            int i = SqlHelper.ExcuteNonQuery(CommandType.Text, insertSql, sqlParam);
            return i;
        }

        public int ModifyArticle(string title, string content, int typeId, int articleId)
        {
            string updateSql = "update Articles set Title=@Title, Contents=@Contents, CreateDate=@CreateDate,TypeId=@TypeId where ArticleId=@id";
            SqlParameter[] sqlParam = {
                    new SqlParameter("@Title",SqlDbType.NVarChar,100),
                    new SqlParameter("@Contents",SqlDbType.NVarChar),
                    new SqlParameter("@CreateDate",SqlDbType.DateTime),
                    new SqlParameter("@TypeId",SqlDbType.Int),
                    new SqlParameter("@id",SqlDbType.Int)
                };
            sqlParam[0].Value = title;
            sqlParam[1].Value = content;
            sqlParam[2].Value = DateTime.Now;
            sqlParam[3].Value = typeId;
            sqlParam[4].Value = articleId;
            int i = SqlHelper.ExcuteNonQuery(CommandType.Text, updateSql, sqlParam);
            return i;
        }

        public DataSet ShowArticle(int userid)
        {
            string sql = "select ArticleId,Title,CreateDate from Articles where CreateUserId = @CreateUserId order by CreateDate" ;
            SqlParameter[] sqlParam = {
                    new SqlParameter("@CreateUserId",SqlDbType.Int)
                };
            sqlParam[0].Value = userid;
            DataSet dshow = SqlHelper.ExcuteDataSet(sql, CommandType.Text,sqlParam);
            return dshow;
        }

        public DataSet ArticleDetails(int articleId)
        {
            string sql = "select Title,Contents,CreateDate from Articles where ArticleId=@id";
            SqlParameter[] sqlParam = {
                    new SqlParameter("@id",SqlDbType.Int)
            };
            sqlParam[0].Value = articleId;
            DataSet ds = SqlHelper.ExcuteDataSet(sql, CommandType.Text, sqlParam);
            return ds;
        }

        public DataSet GetArticleType()
        {
            string sql = "select TypeName from ArticleType";
            DataSet ds = SqlHelper.ExcuteDataSet(sql);
            return ds;
        }

        public DataSet GetArticleId(string type)
        {
            string sql = "select TypeId from ArticleType where TypeName = @type";
            SqlParameter[] sqlParam = {
                new SqlParameter("@type",SqlDbType.NVarChar,10)
            };
            sqlParam[0].Value = type;
            DataSet ds = SqlHelper.ExcuteDataSet(sql,CommandType.Text,sqlParam);
            return ds;
        }

        public DataSet GetArticleType(int id)
        {
            string sql = "select TypeName from ArticleType where TypeId=(select TypeId from Articles where ArticleId = @articleId)";
            SqlParameter[] sqlParam = {
                new SqlParameter("@articleId",SqlDbType.Int)
            };
            sqlParam[0].Value = id;
            DataSet ds = SqlHelper.ExcuteDataSet(sql, CommandType.Text, sqlParam);
            return ds;
        }
    }
}
