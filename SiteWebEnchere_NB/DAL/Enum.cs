using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.DAL
{
    public class Enum
    {
        public enum MapperType
        {
            MEMORY,
            MYSQL,
            MSSQL,
            ORACLE,
            FLAT_FILE,
            XML,
            NONE
        }
    }
}