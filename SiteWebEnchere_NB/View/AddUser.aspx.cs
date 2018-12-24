using GestionEnchereClassLibrary.Model;
using SiteWebEnchere_NB.DAL.MSSQL;
using SiteWebEnchere_NB.Helper;
using SiteWebUtilisateur_NB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace SiteWebEnchere_NB.View
{
    public partial class AddUser : System.Web.UI.Page
    {
        private MSSQLDataMapperFactory _MSSQLdataMapperFactory;
        private IUtilisateurMapper _utilisateurMapper;

        protected void Page_Load(object sender, EventArgs e)
        {
            _MSSQLdataMapperFactory = new MSSQLDataMapperFactory();
            _utilisateurMapper = _MSSQLdataMapperFactory.GetUtilisateurMapper();
        }

        protected void SubmitNewUser(object sender, EventArgs e)
        {
            BO_Utilisateur utilisateur = new BO_Utilisateur()
            {
                NomUtilisateur = TextBox_NomUtilisateur.Text,
                MotDePasse = TextBox_MDP.Text,
                MotDePasseConfirmation = TextBox_MDP2.Text,
                Courriel = TextBox_Courriel.Text,
                CourrielConfirmation = TextBox_Courriel2.Text,
                Nom = TextBox_Nom.Text,
                Prenom = TextBox_Prenom.Text,
                Adresse = TextBox_Adresse.Text,
                Langue = DropDownList_Langue.SelectedValue  
            };

            DateTime dateNaissance;
            if(DateTime.TryParse(TextBox_DateNaissance.Text, out dateNaissance))
                utilisateur.DateNaissance = dateNaissance;


            List<ValidationResult> validationResults = ModelValidationHelper.ValidBusinessModel(utilisateur);
            if(!utilisateur.HasOver18())
                validationResults.Add(new ValidationResult("Vous devez avoir plus de 18 pour vous inscrire"));

            if(validationResults.Any())
            {
                foreach (var validationResult in validationResults)
                    Response.Write("<p class='bg-danger'>" + validationResult.ErrorMessage.ToString() +"</p>" );

                return;
            }

            bool insertResult = _utilisateurMapper.Insert(utilisateur) > int.MinValue;

            Response.Write("<p class='bg-success'>Votre utilisateur a été créé, veuillez vous connecter</p>");
        }
    }
}