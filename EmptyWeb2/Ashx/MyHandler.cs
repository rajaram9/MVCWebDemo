using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyWeb2.Ashx
{
    public class MyHandler : IHttpHandler
    {
        #region IHttpHandler 成员

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        #endregion
    }
}