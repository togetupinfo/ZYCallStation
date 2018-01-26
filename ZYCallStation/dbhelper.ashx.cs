using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

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
                case "a":

                    break;
                case "b":

                    break;

                default:
                    break;
            }
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public string getconfig(HttpRequest httpreq)
        {
            try
            {

                string clientip = httpreq.Params["ip"];
                string sql = "";
                DbHelperSQL conn = new DbHelperSQL();
                DataSet ds = conn.Query(sql);

                return JsonConvert.SerializeObject(ds);

            }
            catch (Exception)
            {

                throw;
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