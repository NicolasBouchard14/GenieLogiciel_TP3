﻿using GestionEnchereClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.DAL
{
    public interface IDemandeCreationEnchereMapper
    {

        bool SaveToXML(BO_DemandeCreationEnchere pDemandeCreationEnchere);
    }
}