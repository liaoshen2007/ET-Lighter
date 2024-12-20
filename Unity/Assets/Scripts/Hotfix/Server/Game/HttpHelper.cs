﻿using System.Net;
using System.Text;

namespace ET.Server
{
    public static partial class HttpHelper
    {
        public static void Response(HttpListenerContext context, object response)
        {
            byte[] bytes = MongoHelper.ToJson(response).ToUtf8();
            context.Response.StatusCode = 200;
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.ContentLength64 = bytes.Length;
            context.Response.ContentType = "application/json;charset:utf-8;";
            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
        }
        
        public static void Response(HttpListenerContext context, byte[] bytes)
        {
            context.Response.StatusCode = 200;
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.ContentLength64 = bytes.Length;
            context.Response.ContentType = "application/json;charset:utf-8;";
            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
        }
    }
}