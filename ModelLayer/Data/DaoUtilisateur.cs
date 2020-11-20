using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Business;
namespace ModelLayer.Data
{
    class DaoUtilisateur
    {
        private Dbal mydbal;
        private DaoUtilisateur theDaoUser;

        public DaoUtilisateur(Dbal dbal, DaoUtilisateur DaoUser)
        {
            this.mydbal = dbal;
            this.theDaoUser = DaoUser;
        }

        public void Insert(Utilisateur unUser)
        {
            string query = "Utilisateur (id, role, idVille, identifiant, mdp) VALUES ("
                + unUser.Id + ",'"
                + unUser.Role + "',"
                + unUser.Ville.Id + ",'"
                + unUser.Identifiant.Replace("'", "''") + ","
                + unUser.Mdp.Replace("'", "''") + ")";
            this.mydbal.Insert(query);

        }

        public void Update(Utilisateur unUser)
        {
            string query = "Utilisateur Set id= " + unUser.Id
                + ", role = '" + unUser.Role
                + ", ville = " + unUser.Ville.Id
                + ", identifiant = '" + unUser.Identifiant.Replace("'", "''")
                + ", mdp = '" + unUser.Mdp.Replace("'", "''");
            this.mydbal.Update(query);
        }

        public void Delete(Utilisateur unUser)
        {
            string query = "Utilisateur Where id = " + unUser.Id;
            this.mydbal.Delete(query);
        }
    }
}
