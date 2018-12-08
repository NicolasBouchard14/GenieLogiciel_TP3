using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.DAL.MSSQL
{
    public class MSSQLDataMapperFactory : DataMapperFactory
    {
        public MSSQLDataMapperFactory()
        {
        }


        public override IEnchereMapper GetEnchereMapper()
        {
            return new EnchereMapper();
        }
    }
}