using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Resource = SiteWebEnchere_NB.Ressources.Resource;

namespace SiteWebEnchere_NB.View
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.User.Identity.IsAuthenticated)
            {
                Panel_NavBarLinks_Authenticated.Visible = true;
                Panel_NavBarLinks_Unauthenticated.Visible = false;
                Panel_Logout.Visible = true;
            }
        }

        protected void Logout(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Response.Redirect(string.Format(Resource.CommandUrl, "Home"));
        }
    }
}