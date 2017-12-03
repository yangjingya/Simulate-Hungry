using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class reader
    {
        public DataTable Read(string strSQL)
        {

            //1.数据库的连接
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BookManageSystem.mdf;Integrated Security=True;User Instance=True";
            conn.Open();
            //3.封装SQL命令
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = strSQL;
            //4.执行命令
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();//本地内存中
            da.Fill(ds);

            //5.断开连接
            conn.Close();

            return ds.Tables[0];

        }
    }
}
