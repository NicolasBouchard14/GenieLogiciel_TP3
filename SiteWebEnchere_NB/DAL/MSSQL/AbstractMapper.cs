using GestionEnchereClassLibrary.Model;
using System.Collections.Generic;


namespace SiteWebEnchere_NB.DAL.MSSQL
{
    public abstract class AbstractMapper
    {
        private Dictionary<int, BO_BaseModel> lLoadedMap = new Dictionary<int, BO_BaseModel>();

        public AbstractMapper() { }

        protected BO_BaseModel AbstractFind(int pID)
        {
            if (lLoadedMap.ContainsKey(pID))
            {
                return lLoadedMap[pID];
            }
            return null;
        }

        protected Dictionary<int, BO_BaseModel> LoadedMap
        {
            get { return lLoadedMap; }
            set { lLoadedMap = value; }
        }
    }
}