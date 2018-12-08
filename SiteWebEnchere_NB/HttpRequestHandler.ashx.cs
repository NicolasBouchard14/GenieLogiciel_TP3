using SiteWebEnchere_NB.Command;
using System;
using System.Web;

namespace SiteWebEnchere_NB
{
    /// <summary>
    /// Description résumée de HttpRequestHandler
    /// </summary>
    public class HttpRequestHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            FrontCommand command = getCommand(context.Request);
            command.Init(context, context.Request, context.Response);
            command.Process();
        }

        private FrontCommand getCommand(HttpRequest request){ return (FrontCommand)getCommandClass(request); }

        private object getCommandClass(HttpRequest request)
        {
            string command = request["command"];
            string commandClassName = System.Configuration.ConfigurationManager.AppSettings[command];
            if (commandClassName != null)
            {
                Type type = Type.GetType(commandClassName);
                if (type != null)
                {
                    return type.GetConstructor(new Type[0]).Invoke(new Object[0]);
                }
            }

            return new UnknownCommand();
        }


        public bool IsReusable
        {
            get { return false; }
        }
    }
}