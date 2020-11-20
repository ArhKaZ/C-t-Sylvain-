using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Business;
namespace ModelLayer.Data
{
    class DaoReservation
    {
        private Dbal mydbal;
        private DaoReservation theDaoReservation;

        public DaoReservation(Dbal dbal, DaoReservation daoReservation)
        {
            this.mydbal = dbal;
            this.theDaoReservation = daoReservation;
        }

        public void Insert(Reservation uneReservation)
        {
            string query = "Salle (dateRes, id, idClient, idSalle, prix, idtechnicien, nbClient, idTheme) VALUES ('"
                + uneReservation.DateRes + "',"
                + uneReservation.Id + ","
                + uneReservation.IdClient.Id + ","
                + uneReservation.IdSalle.Id + ","
                + uneReservation.Prix + ","
                + uneReservation.IdTechnicien + ","
                + uneReservation.NbClient + ","
                + uneReservation.IdTheme + ")";
                
                

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
}
