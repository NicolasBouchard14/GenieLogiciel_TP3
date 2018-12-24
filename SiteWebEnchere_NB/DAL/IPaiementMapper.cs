using GestionEnchereClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteWebEnchere_NB.DAL
{
    public interface IPaiementMapper
    {
        bool SaveToXml(BO_Paiement pEncherissement);
    }
}
