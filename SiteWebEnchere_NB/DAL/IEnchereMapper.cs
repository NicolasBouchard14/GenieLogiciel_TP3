using SiteWebEnchere_NB.Model;
using System.Data;

namespace SiteWebEnchere_NB.DAL
{
    public interface IEnchereMapper
    {
        Enchere Find(int IdEnchere);
        DataTable FindAll();

        int Insert(Enchere pEnchere);
        int Update(Enchere pEnchere);
        int Delete(Enchere pEnchere);
    }
}