using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Data;
using System.Text;
using DAL;
using Model;
using BLL;

namespace WebApplication1
{
    /// <summary>
    /// ModifyInformation 的摘要说明
    /// </summary>
    public class ModifyInformation : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            DataTable dt = new DataTable();
            StringBuilder str = new StringBuilder();
            readerManage rm = new readerManage();
            string account = string.Empty;
            if (context.Session["readerAccount"] != null)
            {
                account = context.Session["readerAccount"].ToString();
            }
            dt = rm.checkInfo(account);
            str.Append("{reader:[{readerNo:'" + dt.Rows[0]["readerNo"] + "',readerPwd:'" + dt.Rows[0]["readerPwd"] +
                "',readerName:'" + dt.Rows[0]["readerName"] +"',rSex:'" + dt.Rows[0]["rSex"] + "',rPhoneNum:'" +
                dt.Rows[0]["rPhoneNum"] + "',institute:'" +dt.Rows[0]["institute"] + "',province:'" + dt.Rows[0]["province"] + "',city:'" + dt.Rows[0]["city"] + "'}]}");
            context.Response.Write(str.ToString());
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