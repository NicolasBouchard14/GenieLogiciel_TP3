using System;
using GestionEnchereClassLibrary.Model;
using SiteWebEnchere_NB.DAL;
using System.Web.Security;
using SiteWebEnchere_NB.Command;
using SiteWebEnchere_NB.DAL.XML;

namespace SiteWebEnchere_NB.View
{
    public partial class AddEnchere : System.Web.UI.Page
    {
        private XMLDataMapperFactory _XMLdataMapperFactory;
        private IDemandeCreationEnchereMapper _demandeCreationEnchereMapper;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            _XMLdataMapperFactory = new XMLDataMapperFactory();
            _demandeCreationEnchereMapper = _XMLdataMapperFactory.GetDemandeCreationEnchereMapper();
        }

        protected void SubmitEnchere(object source, EventArgs e)
        {
            BO_DemandeCreationEnchere demandeCreationEnchere = new BO_DemandeCreationEnchere();
            demandeCreationEnchere.NomEnchere = TextBox_NomEnchere.Text;

            _demandeCreationEnchereMapper.SaveToXML(demandeCreationEnchere);

            HomeCommand command = new HomeCommand();
            command.Process();
        }
    }
}