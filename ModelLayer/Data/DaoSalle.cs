using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Business;
namespace ModelLayer.Data
{
    class DaoSalle
    {
        private Dbal mydbal;
        private DaoSalle theDaoSalle;

        public DaoSalle(Dbal dbal, DaoSalle DaoSalle)
        {
            this.mydbal = dbal;
            this.theDaoSalle = DaoSalle;
        }

        public void Insert(Salle uneSalle)
        {
            string query = "Salle (id, idLieu, idTheme) VALUES ("
                + uneSalle.Id + ","
                + uneSalle.IdLieu.Id + ","
                + uneSalle.IdTheme.Id + ")";
                
            this.mydbal.Insert(query);

        }

        public void Update(Salle uneSalle)
        {
            string query = "Salle Set id= " + uneSalle.Id
                + ", idLieu = " + uneSalle.IdLieu.Id
                + ", idTheme = " + uneSalle.IdTheme.Id;
              
            this.mydbal.Update(query);
        }

        public void Delete(Salle uneSalle)
        {
            string query = "Salle Where id = " + uneSalle.Id;
            this.mydbal.Delete(query);
        }
    }
}
