using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 管理系统
{
    class SqlHelper
    {
        //定义全局静态变量connstring,用于连接数据库
        
        public string connstring = "Data Source = DESKTOP-7QAU5M6; Initial Catalog = 管理系统; User ID = sa; Password=123456";

        public SqlConnection conn;

        public int hsgexucute(string sql)      //自定义函数:执行sql语句
        {
            //连接数据库
            conn = new SqlConnection(connstring);
            int a = -1;

            try
            {
                conn.Open();  //打开数据库  
                SqlCommand cmd = new SqlCommand(sql, conn);
                a = cmd.ExecuteNonQuery();
            }
            catch
            {
                //如果出现异常,返回值0
                return 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();    //关闭数据库  
                }
            }
            return a;
        }

        public DataSet hsggetdata(string sql)  //自定义函数,用于查询数据库操作
        {
            conn = new SqlConnection(connstring);
            DataSet ds = new DataSet();

            try
            {
                conn.Open();      //打开数据库  
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }

            catch
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();      //关闭数据库  
            }
            return ds;
        }
    }
}
