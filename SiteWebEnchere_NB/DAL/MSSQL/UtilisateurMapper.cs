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

        public BO_Utilisateur Find(string pUsername)
        {
            DataRow row = DataBase.SelectRow("[dbo].[Utilisateur]", $"NomUtilisateur = '{pUsername}'");
            if (Util.isNULL(row))
                return null;
            BO_Utilisateur utilisateur = this.FillFields(row);
            LoadedMap.Add(utilisateur.ID, utilisateur);

            return utilisateur;
        }

        private BO_Utilisateur FillFields(DataRow pDataRow)
        {
            BO_Utilisateur utilisateur = new BO_Utilisateur();

            utilisateur.ID = (int)pDataRow["ID"];
            utilisateur.NomUtilisateur = (string)pDataRow["NomUtilisateur"];
            utilisateur.Courriel = (string)pDataRow["Courriel"];

            return utilisateur;
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