using System;
using GestionEnchereClassLibrary.Model;
using SiteWebEnchere_NB.DAL;
using System.Web.Security;
using SiteWebEnchere_NB.DAL.XML;
using System.Net;
using System.Net.Http;
using Resource = SiteWebEnchere_NB.Ressources.Resource;
using SiteWebEnchere_NB.DAL.MSSQL;
using SiteWebUtilisateur_NB.DAL;

namespace SiteWebEnchere_NB.View
{
    public partial class AddEnchere : System.Web.UI.Page
    {
        private XMLDataMapperFactory _XMLdataMapperFactory;
        private MSSQLDataMapperFactory _MSSQLdataMapperFactory;
        private IDemandeCreationEnchereMapper _demandeCreationEnchereMapper;
        private IUtilisateurMapper _utilisateurMapper;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            _XMLdataMapperFactory = new XMLDataMapperFactory();
            _MSSQLdataMapperFactory = new MSSQLDataMapperFactory();
            _utilisateurMapper = _MSSQLdataMapperFactory.GetUtilisateurMapper();
            _demandeCreationEnchereMapper = _XMLdataMapperFactory.GetDemandeCreationEnchereMapper();
        }

        protected void SubmitEnchere(object source, EventArgs e)
        {
            BO_DemandeCreationEnchere demandeCreationEnchere = new BO_DemandeCreationEnchere();
            demandeCreationEnchere.NomEnchere = TextBox_NomEnchere.Text;
            demandeCreationEnchere.IdUtilisateur_Vendeur = _utilisateurMapper.Find(User.Identity.Name).ID;
            demandeCreationEnchere.Duree = Convert.ToInt32(TextBox_Duree.Text);
            demandeCreationEnchere.Categorie = DropDownList_Categorie.Text;

            _demandeCreationEnchereMapper.SaveToXML(demandeCreationEnchere);

            Response.Redirect(string.Format(Resource.CommandUrl, "Home"));
        }
    }
}