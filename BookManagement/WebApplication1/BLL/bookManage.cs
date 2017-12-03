using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using DAL;

namespace BLL
{
    public class bookManage
    {
        public bool isBookExits(Book book)
        {
            string strSQL = string.Empty;

            DataTable dt = new DataTable();

            //根据传递进来的用户生成SQL查询语句
            strSQL = "select * from BookInfomation where readerNo='" + book.bookNo;

            //调用数据库访问层中的Read()方法，得到查询结果：DataTable类型的
            reader reader = new reader();
            dt = reader.Read(strSQL);

            //根据查询到的用户信息判断该用户是否存在
            if (dt.DefaultView.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
