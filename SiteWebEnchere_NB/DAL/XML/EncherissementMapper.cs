using GestionEnchereClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SiteWebEnchere_NB.DAL.XML
{
    public class EncherissementMapper : IEncherissementMapper
    {
        public bool SaveToXml(BO_Encherissement pDemandeCreationEnchere)
        {
            try
            {
                var path = GlobalConfig.getXMLFolderBasePath() + @"\Utilisateur\In\Encherissement\Encherissement.xml";
                XDocument XmlDocument = Util.GetXmlDocumentFromObject(pDemandeCreationEnchere);
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