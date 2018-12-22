using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.Command
{
    public class AuthenticateCommand : FrontCommand
    {
        public override void Process()
        {
            //Redirige vers Authenticate.aspx
            context.Server.Transfer(System.Configuration.ConfigurationManager.AppSettings["AuthenticatePath"], true);
        }
    }
}