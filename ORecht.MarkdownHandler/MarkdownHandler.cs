﻿using System;
using System.Web;
using System.IO;

namespace System.Web.Handlers
{
    public class MarkdownHandler : IHttpHandler
    {
        // Override the ProcessRequest method.
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<!DOCTYPE html>");
            context.Response.Write("<html>");
            context.Response.Write("<xmp theme=\"united\" style=\"display:none;\">");

            context.Response.Write(File.ReadAllText(context.Request.PhysicalPath));

            context.Response.Write("</xmp>");
            context.Response.Write("<script src=\"https://cdn.jsdelivr.net/gh/Naereen/StrapDown.js@master/strapdown.min.js\"></script>");
            context.Response.Write("</html>");
        }

        // Override the IsReusable property.
        public bool IsReusable
        {
            get { return true; }
        }
    }
}
