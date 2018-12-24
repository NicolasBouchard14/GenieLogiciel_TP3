using GestionEnchereClassLibrary.Model;
using System;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SiteWebEnchere_NB.DAL.MSSQL
{
    public class EnchereMapper : AbstractMapper, IEnchereMapper
    {
        public int Delete(BO_Enchere pEnchere)
        {
            throw new NotImplementedException();
        }

        public BO_Enchere Find(int ID)
        {
            BO_Enchere enchere = (BO_Enchere)AbstractFind(ID);

            if (Util.isNULL(enchere))
            {
                DataRow row = DataBase.SelectID(ID, "[dbo].[DemandeCreationEnchere]");
                if (Util.isNULL(row))
                    return null;
                enchere = this.FillFields(row);
                LoadedMap.Add(enchere.ID, enchere);
            }
            return enchere;
        }

        private BO_Enchere FillFields(DataRow pDataRow)
        {
            BO_Enchere enchere = new BO_Enchere();

            enchere.ID = (int)pDataRow["ID"];
            enchere.DemandeCreationEnchere.IdUtilisateur_Vendeur = (int)pDataRow["IdUtilisateur_Vendeur"];
            enchere.DemandeCreationEnchere.NomEnchere = (string)pDataRow["NomEnchere"];
            enchere.DemandeCreationEnchere.TypeEnchere = (string)pDataRow["TypeEnchere"];
            enchere.DemandeCreationEnchere.PrixMinimum = (decimal)pDataRow["PrixMinimum"];
            enchere.DemandeCreationEnchere.Duree = (int)pDataRow["Duree"];
            enchere.DemandeCreationEnchere.OptionTransport = (string)pDataRow["OptionTransport"];
            enchere.DemandeCreationEnchere.MotsCles = (string)pDataRow["MotsCles"];
            enchere.DemandeCreationEnchere.AutresInformations = (string)pDataRow["AutresInformations"];

            return enchere;
        }

        public DataSet FindAll()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(DataBase.SelectTable("[dbo].[DemandeCreationEnchere]", ""));
            return ds;
        }

        public int Insert(BO_Enchere pEnchere)
        {
            throw new NotImplementedException();
        }

        public int Update(BO_Enchere pEnchere)
        {
            throw new NotImplementedException();
        }
    }
}