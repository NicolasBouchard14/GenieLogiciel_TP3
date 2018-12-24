using GestionEnchereClassLibrary.Model;
using SiteWebEnchere_NB.DAL;
using SiteWebEnchere_NB.DAL.XML;
using SiteWebEnchere_NB.Ressources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWebEnchere_NB.View
{
    public partial class PayEnchere : System.Web.UI.Page
    {
        private XMLDataMapperFactory _XMLdataMapperFactory;
        private IPaiementMapper _paiementMapper;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            _XMLdataMapperFactory = new XMLDataMapperFactory();
            _paiementMapper = _XMLdataMapperFactory.GetPaiementMapper();
        }

        protected void PayerEnchere(object sender, EventArgs e)
        {
            BO_Paiement paiement = new BO_Paiement()
            {
                IdEnchere = Convert.ToInt32(Request["ID"]),
                InfosPaiement = TextBox_InformationsPaiement.Text
            };

            _paiementMapper.SaveToXml(paiement);

            Response.Redirect(string.Format(Resource.CommandUrl, "Home"));
        }
    }
}