using SiteWebEnchere_NB.DAL;
using SiteWebEnchere_NB.DAL.MSSQL;
using SiteWebEnchere_NB.DAL.XML;
using SiteWebUtilisateur_NB.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWebEnchere_NB.View
{
    public partial class Authenticate : System.Web.UI.Page
    {
        private XMLDataMapperFactory _XMLdataMapperFactory;
        private IDemandeCreationEnchereMapper _demandeCreationEnchereMapper;

        protected void Page_Load(object sender, EventArgs e)
        {
            _XMLdataMapperFactory = new XMLDataMapperFactory();
            _demandeCreationEnchereMapper = _XMLdataMapperFactory.GetDemandeCreationEnchereMapper();
        }

        protected void ValidateUser(object sender, EventArgs e)
        {
            if (Login.UserName == "" || Login.Password == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "ShowNotification('Warning','Email is Required');", true);
                return;
            }

            try
            {
                MSSQLDataMapperFactory dataMapper = new MSSQLDataMapperFactory();
                IUtilisateurMapper utilisateurMapper = dataMapper.GetUtilisateurMapper();
                bool result = false;

                DataTable dt = utilisateurMapper.FindAll();

                foreach (DataRow row in dt.Rows)
                {
                    if (row.Field<string>("NomUtilisateur") == Login.UserName &&
                        row.Field<string>("MotDePasse") == Login.Password)
                    {
                        FormsAuthentication.RedirectFromLoginPage(Login.UserName, false);
                        result = true;
                    }
                }

                if (!result)
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "ShowNotification('Warning','No user found');", true);
            }
            catch (Exception ex)
            {
                //Log exception
            }
        }
    }
}