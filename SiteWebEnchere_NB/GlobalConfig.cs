using System.Configuration;
using static SiteWebEnchere_NB.DAL.Enum;

namespace SiteWebEnchere_NB
{
    public class GlobalConfig
    {
        public static string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        }

        public static MapperType getMapperType()
        {
            return MapperType.MSSQL;
        }
    }
}