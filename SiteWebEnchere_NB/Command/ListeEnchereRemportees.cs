﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.Command
{
    public class ListeEnchereRemporteesCommand : FrontCommand
    {
        public override void Process()
        {
            //Redirige vers Home.aspx
            context.Server.Transfer(System.Configuration.ConfigurationManager.AppSettings["ListeEnchereRemporteesPath"], true);
        }
    }
}