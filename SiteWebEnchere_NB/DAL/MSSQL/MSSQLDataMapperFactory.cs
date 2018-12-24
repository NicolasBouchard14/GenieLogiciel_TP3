using SiteWebUtilisateur_NB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.DAL.MSSQL
{
    public class MSSQLDataMapperFactory : DataMapperFactory
    {
        public MSSQLDataMapperFactory()
        {
        }

        public override IDemandeCreationEnchereMapper GetDemandeCreationEnchereMapper()
        {
            throw new NotImplementedException();
        }

        public override IEnchereMapper GetEnchereMapper()
        {
            return new EnchereMapper();
        }

        public override IEncherissementMapper GetEncherissementMapper()
        {
            throw new NotImplementedException();
        }

        public override IPaiementMapper GetPaiementMapper()
        {
            throw new NotImplementedException();
        }

        public override IUtilisateurMapper GetUtilisateurMapper()
        {
            return new UtilisateurMapper();
        }
    }
}