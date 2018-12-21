using GestionEnchereClassLibrary.Model;
using System.Data;

namespace SiteWebUtilisateur_NB.DAL
{
    public interface IUtilisateurMapper
    {
        BO_Utilisateur Find(int IdUtilisateur);
        DataTable FindAll();

        int Insert(BO_Utilisateur pUtilisateur);
        int Update(BO_Utilisateur pUtilisateur);
        int Delete(BO_Utilisateur pUtilisateur);
    }
}