using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Business;
namespace ModelLayer.Data
{
    class DaoTheme
    {
        private Dbal mydbal;
        private DaoTheme theDaoTheme;

        public DaoTheme(Dbal dbal, DaoTheme DaoTheme)
        {
            this.mydbal = dbal;
            this.theDaoTheme = DaoTheme;
        }

        public void Insert(Theme unTheme)
        {
            string query = "Theme (id, nom) VALUES ("
                + unTheme.Id + ",'"
                + unTheme.Nom.Replace("'","''") + "')";
                
            this.mydbal.Insert(query);

        }

        public void Update(Theme unTheme)
        {
            string query = "Utilisateur Set id= " + unTheme.Id
                + ", nom = '" + unTheme.Nom.Replace("'", "''") + ")";
            this.mydbal.Update(query);
        }

        public void Delete(Theme unTheme)
        {
            string query = "Theme Where id = " + unTheme.Id;
            this.mydbal.Delete(query);
        }
    }
}
