using SiteWebUtilisateur_NB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SiteWebEnchere_NB.DAL.Enum;

namespace SiteWebEnchere_NB.DAL
{
    public abstract class DataMapperFactory
    {
        public abstract IEnchereMapper GetEnchereMapper();

        public abstract IDemandeCreationEnchereMapper GetDemandeCreationEnchereMapper();

        public abstract IUtilisateurMapper GetUtilisateurMapper();

        public abstract IEncherissementMapper GetEncherissementMapper();

        public abstract IPaiementMapper GetPaiementMapper();

        public static DataMapperFactory GetDataMapperFactory()
        {
            switch (GlobalConfig.getMapperType())
            {
                case MapperType.MEMORY:
                    return null;
                case MapperType.MSSQL:
                    return new MSSQL.MSSQLDataMapperFactory();
                case MapperType.MYSQL:
                    return null;
                case MapperType.ORACLE:
                    return null;
                case MapperType.FLAT_FILE:
                    return null;
                case MapperType.XML:
                    return new XML.XMLDataMapperFactory();
                case MapperType.NONE:
                    return null;
                default:
                    return null;
            }

        }
    }
}