using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Model;
using BLL;
using DAL;

namespace WebApplication1
{
    /// <summary>
    /// DataSave 的摘要说明
    /// </summary>
    public class DataSave : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            Reader re = new Reader();
            readerManage rm = new readerManage();
            bool ret;
            var readerNo = string.Empty;
            var readerPwd = string.Empty;
            var readerName = string.Empty;
            var rSex = string.Empty;
            var rPhoneNum = string.Empty;
            var institute = string.Empty;
            var province = string.Empty;
            var city = string.Empty;

            readerNo = context.Request.Form["readerNo"].ToString();
            readerPwd = context.Request.Form["readerPwd"].ToString();
            readerName = context.Request.Form["readerName"].ToString();
            rSex = context.Request.Form["rSex"].ToString();
            rPhoneNum = context.Request.Form["rPhoneNum"].ToString();
            institute = context.Request.Form["institute"].ToString();
            province = context.Request.Form["province"].ToString();
            city = context.Request.Form["city"].ToString();

            
            re.readerNo = readerNo;
            re.readerPwd = readerPwd;
            re.readerName = readerName;
            re.rSex = rSex;
            re.rPhoneNum = rPhoneNum;
            re.institute = institute;
            re.province = province;
            re.city = city;

            ret = rm.modifyInfo(re);
            if (ret == true)
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write("true");
            }
            else
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write("false");
            }
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}