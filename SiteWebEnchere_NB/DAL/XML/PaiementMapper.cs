using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionEnchereClassLibrary.Model;
using System.Xml.Linq;

namespace SiteWebEnchere_NB.DAL.XML
{
    public class PaiementMapper : IPaiementMapper
    {
        public bool SaveToXml(BO_Paiement pPaiement)
        {
            try
            {
                var path = GlobalConfig.getXMLFolderBasePath() + @"\Utilisateur\In\Paiement\Paiement.xml";
                XDocument XmlDocument = Util.GetXmlDocumentFromObject(pPaiement);
                XmlDocument.Save(path);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}