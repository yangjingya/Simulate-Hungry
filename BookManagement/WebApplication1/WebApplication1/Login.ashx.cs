using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using BLL;
using System.Web.SessionState;

namespace WebApplication1
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            bool isUser;

            string readerNo = string.Empty;
            string readerPwd = string.Empty;
            readerNo = context.Request.Form["readerNo"].ToString();
            readerPwd = context.Request.Form["readerPwd"].ToString();

            readerManage rm = new readerManage();
            isUser=rm.CheckUser(readerNo, readerPwd);

            if (isUser == true)
            {
                context.Response.ContentType = "text/plain";
                context.Session["readerAccount"] = readerNo;
                context.Response.Write("true");
            }
            else {
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