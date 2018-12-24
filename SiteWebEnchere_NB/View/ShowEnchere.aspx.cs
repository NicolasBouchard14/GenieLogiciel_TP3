using GestionEnchereClassLibrary.Model;
using SiteWebEnchere_NB.DAL;
using SiteWebEnchere_NB.DAL.MSSQL;
using SiteWebEnchere_NB.DAL.XML;
using SiteWebUtilisateur_NB.DAL;
using System;

namespace SiteWebEnchere_NB.View
{
    public partial class ShowEnchere : System.Web.UI.Page
    {
        private MSSQLDataMapperFactory _MSSQLdataMapperFactory;
        private XMLDataMapperFactory _XMLDataMapperFactory;
        private IEnchereMapper _enchereMapper;
        private IUtilisateurMapper _utilisateurMapper;
        private IEncherissementMapper _encherissementMapper;
        private int _enchereID;

        protected void Page_Load(object sender, EventArgs e)
        {
            _MSSQLdataMapperFactory = new MSSQLDataMapperFactory();
            _enchereMapper = _MSSQLdataMapperFactory.GetEnchereMapper();
            _enchereID = Convert.ToInt32(Request["ID"]);
            BO_Enchere enchere = _enchereMapper.Find(_enchereID);

            if(enchere != null)
            {
                TextBox_NomEnchere.Text = enchere.DemandeCreationEnchere.NomEnchere;
                TextBox_PrixMin.Text = enchere.DemandeCreationEnchere.PrixMinimum.ToString();
                TextBox_Duree.Text = enchere.DemandeCreationEnchere.Duree.ToString();
                DropDownList_Categorie.SelectedValue = enchere.DemandeCreationEnchere.Categorie;
                DropDownList_OptionTransport.SelectedValue = enchere.DemandeCreationEnchere.OptionTransport;
                DropDownList_TypeEnchere.SelectedValue = enchere.DemandeCreationEnchere.TypeEnchere;
                TextBox_AutresInfos.Text = enchere.DemandeCreationEnchere.AutresInformations;
            }

            if (this.Page.User.Identity.IsAuthenticated)
            {
                Panel_Action.Visible = true;
            }

        }

        protected void SubmitEncherissement(object sender, EventArgs e)
        {
            _XMLDataMapperFactory = new XMLDataMapperFactory();
            _utilisateurMapper = _MSSQLdataMapperFactory.GetUtilisateurMapper();
            _encherissementMapper = _XMLDataMapperFactory.GetEncherissementMapper();

            if(Convert.ToInt32(TextBox_OffreMaximale.Text) < Convert.ToDecimal(TextBox_PrixMin.Text))
            {
                Response.Write("<p class='bg-danger'>Votre offre doit être spérieure au montant minimal demandé</p>");
                return;
            }

            BO_Encherissement encherissement = new BO_Encherissement()
            {
                IdEnchere = _enchereID,
                OffreMaximale = Convert.ToInt32(TextBox_OffreMaximale.Text),
                IdUtilisateur_Encherisseur = _utilisateurMapper.Find(User.Identity.Name).ID
            };

            _encherissementMapper.SaveToXml(encherissement);

            Response.Write("<p class='bg-success'>Votre enchère a été enregistrée</p>");
        }

        protected void FollowEnchere(object sender, EventArgs e)
        {
            //TODO: Suivre l'enchère
        }
    }
}