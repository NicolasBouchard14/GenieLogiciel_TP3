using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.Command
{
    public abstract class FrontCommand
    {
        protected HttpContext context;
        protected HttpRequest request;
        protected HttpResponse response;

        public void Init(HttpContext context, HttpRequest request, HttpResponse response)
        {
            this.context = context;
            this.request = request;
            this.response = response;
        }

        abstract public void Process();

        // method foward

    }
}