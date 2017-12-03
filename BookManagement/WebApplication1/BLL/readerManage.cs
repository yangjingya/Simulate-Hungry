using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class readerManage
    {
        //public bool isUserExits(Reader re)
        //{
        //    string strSQL = string.Empty;

        //    DataTable dt = new DataTable();

        //    //根据传递进来的用户生成SQL查询语句
        //    strSQL = "select * from readerInfomation where readerNo='" + re.readerNo + "' and readerPwd='" + re.readerPwd + "'";

        //    //调用数据库访问层中的Read()方法，得到查询结果：DataTable类型的
        //    reader reader = new reader();
        //    dt = reader.Read(strSQL);

        //    //根据查询到的用户信息判断该用户是否存在
        //    if (dt.DefaultView.Count > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool CheckUser(string account, string password)
        {
            string strSQL = string.Empty;

            //生成查询SQL
            strSQL = "select * from readerInfomation where readerNo='" + account + "' and readerPwd='" + password + "'";
            //调用数据库访问层的读函数
            DataTable dt = new DataTable();
            reader reader = new reader();
            dt = reader.Read(strSQL);
            if (dt.DefaultView.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable checkInfo(string account)
        {
            string strSQL = string.Empty;
            strSQL = "select * from readerInfomation where readerNo='" + account + "'";
            DataTable dt = new DataTable();
            reader reader = new reader();
            dt = reader.Read(strSQL);
            return dt;
        }

        public bool modifyInfo(Reader re)
        {
            string strSQL = string.Empty;
            bool ret;

            //生成一个SQL语句
            strSQL = "update readerInfomation set readerPwd ='" + re.readerPwd + "',readerName='" + re.readerName + "',rSex='" + re.rSex
                + "',rPhoneNum='" + re.rPhoneNum + "',institute='" + re.institute + "',province='" + re.province + "',city='" + re.city + "' where readerNo='"+re.readerNo+"'";
            //调用数据库访问层的Write()方法
            writer wr = new writer();
            ret = wr.Write(strSQL);

            return ret;
        }
    }
}
