using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionEnchereClassLibrary.Model;
using System.Xml.Serialization;
using System.IO;

namespace SiteWebEnchere_NB.DAL.XML
{
    public class DemandeCreationEnchereMapper : IDemandeCreationEnchereMapper
    {
        public void SaveToXML(BO_DemandeCreationEnchere pDemandeCreationEnchere)
        {
            XmlSerializer writer = new XmlSerializer(typeof(BO_DemandeCreationEnchere));
            var path = GlobalConfig.getXMLFolderBasePath() + @"\Utilisateur\In\DemandeCreationEnchere\DemandeCreationEnchere.xml";
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, pDemandeCreationEnchere);
            }
        }
    }
}