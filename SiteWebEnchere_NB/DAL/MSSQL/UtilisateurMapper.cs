using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using GestionEnchereClassLibrary.Model;
using SiteWebUtilisateur_NB.DAL;

namespace SiteWebEnchere_NB.DAL.MSSQL
{
    public class UtilisateurMapper : AbstractMapper, IUtilisateurMapper
    {
        public BO_Utilisateur Find(int IdUtilisateur)
        {
            throw new NotImplementedException();
        }

        public DataTable FindAll()
        {
            return DataBase.SelectTable("[dbo].[Utilisateur]", "");
        }

        public int Insert(BO_Utilisateur pUtilisateur)
        {
            throw new NotImplementedException();
        }

        public int Update(BO_Utilisateur pUtilisateur)
        {
            throw new NotImplementedException();
        }

        public int Delete(BO_Utilisateur pUtilisateur)
        {
            throw new NotImplementedException();
        }
    }
}