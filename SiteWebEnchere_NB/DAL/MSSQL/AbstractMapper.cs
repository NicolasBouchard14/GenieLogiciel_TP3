using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiteWebEnchere_NB.Model;

namespace SiteWebEnchere_NB.DAL.MSSQL
{
    public abstract class AbstractMapper
    {
        private Dictionary<int, BaseModel> lLoadedMap = new Dictionary<int, BaseModel>();

        public AbstractMapper() { }

        protected BaseModel AbstractFind(int pID)
        {
            if (lLoadedMap.ContainsKey(pID))
            {
                return lLoadedMap[pID];
            }
            return null;
        }

        protected Dictionary<int, BaseModel> LoadedMap
        {
            get { return lLoadedMap; }
            set { lLoadedMap = value; }
        }
    }
}