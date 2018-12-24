using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.Command
{
    public class PayEnchereCommand : FrontCommand
    {
        public override void Process()
        {
            //Redirige vers Home.aspx
            context.Server.Transfer(System.Configuration.ConfigurationManager.AppSettings["PayEncherePath"], true);
        }
    }
}