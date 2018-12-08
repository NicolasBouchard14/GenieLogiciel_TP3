using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.Command
{
    public class UnknownCommand : FrontCommand
    {
        public override void Process()
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Front Controller unknown command");
        }
    }
}