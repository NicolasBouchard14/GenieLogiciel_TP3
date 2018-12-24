using GestionEnchereClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.DAL
{
    public interface IEncherissementMapper
    {

        bool SaveToXml(BO_Encherissement pEncherissement);
    }
}