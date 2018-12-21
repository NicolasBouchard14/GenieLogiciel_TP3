using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiteWebUtilisateur_NB.DAL;

namespace SiteWebEnchere_NB.DAL.XML
{
    public class XMLDataMapperFactory : DataMapperFactory
    {
        public XMLDataMapperFactory()
        {
        }

        public override IDemandeCreationEnchereMapper GetDemandeCreationEnchereMapper()
        {
            return new DemandeCreationEnchereMapper();
        }

        public override IEnchereMapper GetEnchereMapper()
        {
            throw new NotImplementedException();
        }

        public override IUtilisateurMapper GetUtilisateurMapper()
        {
            throw new NotImplementedException();
        }
    }
}