using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SiteWebEnchere_NB.DAL.Enum;

namespace SiteWebEnchere_NB.DAL
{
    public abstract class DataMapperFactory
    {
        public abstract IEnchereMapper GetEnchereMapper();

        public static DataMapperFactory GetDataMapperFactory()
        {
            switch (GlobalConfig.getMapperType())
            {
                case MapperType.MEMORY:
                    return null;
                case MapperType.MSSQL:
                    return new MSSQL.MSSQLDataMapperFactory();
                case MapperType.MYSQL:
                    return null;
                case MapperType.ORACLE:
                    return null;
                case MapperType.FLAT_FILE:
                    return null;
                case MapperType.NONE:
                    return null;
                default:
                    return null;
            }

        }
    }
}