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
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pUtilisateur);
            return DataBase.Insert("[dbo].[Utilisateur]", lsCols, lsValues);
        }

        public int Update(BO_Utilisateur pUtilisateur)
        {
            throw new NotImplementedException();
        }

        public int Delete(BO_Utilisateur pUtilisateur)
        {
            throw new NotImplementedException();
        }


        private void FillArray(ref string[] pCols, ref string[] pValues, BO_Utilisateur pUtilisateur)
        {
            int liCpt = 0;

            pCols = new string[8];
            pValues = new string[8];

            pCols[liCpt] = "NomUtilisateur";
            pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.NomUtilisateur) + "'";

            pCols[liCpt] = "MotDePasse";
            pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.MotDePasse) + "'";

            pCols[liCpt] = "Courriel";
            pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.Courriel) + "'";

            pCols[liCpt] = "Prenom";
            pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.Prenom) + "'";

            pCols[liCpt] = "Nom";
            pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.Nom) + "'";

            pCols[liCpt] = "DateNaissance";
            pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.DateNaissance.GetValueOrDefault().ToShortDateString()) + "'";

            pCols[liCpt] = "Adresse";
            pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.Adresse) + "'";

            pCols[liCpt] = "Langue";
            pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.Langue) + "'";

        }
    }
}