using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYCallStation
{
    /// <summary>
    /// dbhelper 的摘要说明
    /// </summary>
    public class dbhelper : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            switch (context.Request.Params["keyword"].ToString())
            {
                case "getconfig":

                    break;
                default:
                    break;
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public string getconfig(HttpRequest httpreq) {
            string clientip = httpreq.Params["ip"];


            return "";
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