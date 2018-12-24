using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace SiteWebEnchere_NB
{
    public class HttpFilter : IHttpModule
    {
        public void Dispose()
        {
            ;
        }

        public void Init(HttpApplication context)
        {
            //context.BeginRequest += new EventHandler(context_BeginRequest);
            context.AuthenticateRequest += new EventHandler(OnAuthentication);
        }

   /*     void context_BeginRequest(object sender, EventArgs eventArgs)
        {
            string adresseUrlRelative = HttpContext.Current.Request.FilePath;
            DateTime date = System.DateTime.Now;
            string actionCommande = HttpContext.Current.Request.QueryString["command"];
            string adresseIP = HttpContext.Current.Request.UserHostAddress;
            string adresseUrlAbsolue = HttpContext.Current.Request.RawUrl;
        }*/

        void OnAuthentication(object sender, EventArgs a)
        {
            string lAdresseUrlRelative = HttpContext.Current.Request.FilePath;
            if (lAdresseUrlRelative.EndsWith(".js") || lAdresseUrlRelative.EndsWith(".css") || lAdresseUrlRelative.EndsWith(".gif") || lAdresseUrlRelative.EndsWith(".png") || lAdresseUrlRelative.EndsWith(".ico")
                || lAdresseUrlRelative.StartsWith("/WebRessource.axd") || lAdresseUrlRelative.StartsWith("/ScriptRessource.axd")) return;
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;

            RequestAccessPage requeteAccesPage = new RequestAccessPage();
            requeteAccesPage.Date = System.DateTime.Now;
            requeteAccesPage.ActionCommand = HttpContext.Current.Request.QueryString["command"];
            requeteAccesPage.AdresseIP = HttpContext.Current.Request.UserHostAddress;
            requeteAccesPage.AdresseUrlAbsolue = HttpContext.Current.Request.RawUrl;
            requeteAccesPage.EstAuthentifie = HttpContext.Current.Request.IsAuthenticated;
            requeteAccesPage.EstConnexionSecure = HttpContext.Current.Request.IsSecureConnection;
            requeteAccesPage.EstLocal = HttpContext.Current.Request.IsLocal;
            requeteAccesPage.AdresseUrlRelative = HttpContext.Current.Request.FilePath;
            requeteAccesPage.IdAnnonyme = HttpContext.Current.Request.AnonymousID;

            IPrincipal user = application.Context.User;
            FormsIdentity identity = null;
            if (application.Context.User != null)
            {
                identity = (FormsIdentity)user.Identity;
                requeteAccesPage.RequestUser = new RequestUser()
                {
                    Username = identity.Name,
                    IsAuthenticated = identity.IsAuthenticated

                };
            }

            string requestJson = JsonConvert.SerializeObject(requeteAccesPage);
            Trace.TraceInformation(requestJson);
        }

        private class RequestAccessPage
        {
            public DateTime Date { get; set; }
            public string ActionCommand { get; set; }
            public string AdresseIP { get; set; }
            public string AdresseUrlAbsolue { get; set; }
            public bool EstAuthentifie { get; set; }
            public bool EstConnexionSecure { get; set; }
            public bool EstLocal { get; set; }
            public string AdresseUrlRelative { get; set; }
            public string IdAnnonyme { get; set; }
            public RequestUser RequestUser {get;set;}
        }

        private class RequestUser
        {
            public string Username { get; set; }
            public bool IsAuthenticated { get; set; }
        }
    }   
}