using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class writer
    {
        SqlConnection conn = new SqlConnection();
        public bool Write(string strSQL)
        {
            int ret;

            try
            {
                //1.数据库的连接
                conn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BookManageSystem.mdf;Integrated Security=True;User Instance=True";
                conn.Open();
                //2.封装SQL命令
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = strSQL;
                //5.返回执行结果
                ret = cmd.ExecuteNonQuery();
                //5.断开连接
                conn.Close();
                if (ret > 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch
            {
                conn.Close();
                return false;
            }


        }
    }
}
