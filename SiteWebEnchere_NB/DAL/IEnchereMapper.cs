using GestionEnchereClassLibrary.Model;
using System.Data;

namespace SiteWebEnchere_NB.DAL
{
    public interface IEnchereMapper
    {
        BO_Enchere Find(int IdEnchere);
        DataSet FindAll();

        int Insert(BO_Enchere pEnchere);
        int Update(BO_Enchere pEnchere);
        int Delete(BO_Enchere pEnchere);
    }
}