using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CourseManageDAL
{
    class SQLHelper
    {
        //获取连接凭证（在config文件里面）
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        //insert、update、delete

        //public static int Update(string sql)、增加默认参数SqlParameter[] param = null
        public static int Update(string sql, SqlParameter[] param = null)
        {
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            //带参数的SQL语句服务
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            //运行
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("执行public static int Update(string sql)发生异常" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql);

            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                throw new Exception("执行public static object GetSingleResult(string sql)发生异常" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                //如果调用一次就把连接对象关了那么reader读不全，让reader自己去关闭连接对象：CommandBehavior.CloseConnection
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch(Exception ex)
            {
                throw new Exception("执行public static SqlDataReader GetReader(string sql)发生异常" + ex.Message);
            }
            //这里不能con.Close()。调用一次读取一条，
            //如果调用一次就把连接对象关了那么reader读不全，让reader自己去关闭连接对象
            //finally
            //{
            //    con.Close();
            //}
        }
    }
}
