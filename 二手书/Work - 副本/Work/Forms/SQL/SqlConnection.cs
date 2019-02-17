using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Work.Forms.SQL
{
    class SqlConnection
    {
        public System.Data.SqlClient.SqlConnection conn;
        public System.Data.SqlClient.SqlDataAdapter da;
        public System.Data.DataSet ds;
        public System.Data.SqlClient.SqlCommand sc;

        static String f = System.Environment.MachineName;
        //创建连接字串，按连接数据库方式的不同写法有差异！！！
        private string strConn =
           //此为 SQL 用户连接数据库的连接字符串，，使用默认端口1433
           //"Data Source=tom-PC;Initial Catalog=student;User ID=sa;Password=saas";
           //此为 WINDOWS 用户连接数据库的连接字符串
           //此为 SQL 用户连接数据库的连接字符串，，使用默认端口1433
           //"Data Source=tom-PC;Initial Catalog=student;User ID=sa;Password=saas";
           //此为 WINDOWS 用户连接数据库的连接字符串
           "Data Source=" + SqlConnection.f + @"\SQLEXPRESS;Initial Catalog=Change;Integrated Security=True";
        public SqlConnection(String strsql)
        {
            conn = new System.Data.SqlClient.SqlConnection(strConn);
            //使用DataAdapter
            da = new SqlDataAdapter(strsql, conn);

            //使用DataSet
            ds = new DataSet();
        }
        public Boolean Connection()
        {
            
            conn.Open();//打开连接
            if (conn.State == ConnectionState.Open)
                return true;
            else
                return false;
        }
        public void Close()
        {
            conn.Close();
        }
    }
}
