using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionEnchereClassLibrary.Model;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace SiteWebEnchere_NB.DAL.XML
{
    public class DemandeCreationEnchereMapper : IDemandeCreationEnchereMapper
    {
        public bool SaveToXML(BO_DemandeCreationEnchere pDemandeCreationEnchere)
        {
            try
            {
                var path = GlobalConfig.getXMLFolderBasePath() + @"\Utilisateur\In\DemandeCreationEnchere\DemandeCreationEnchere.xml";
                XDocument XmlDocument =  Util.ChangeRootNodeNameSpace(pDemandeCreationEnchere);
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