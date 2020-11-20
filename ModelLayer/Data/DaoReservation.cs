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
            string query = "Reservation (dateRes, id, idClient, idSalle, prix, idtechnicien, nbClient, idTheme) VALUES ('"
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

        public void Update(Reservation uneReservation)
        {
            string query = "Salle Set id= '" + uneReservation.DateRes
                + "', id = " + uneReservation.Id
                + ", idClient = " + uneReservation.IdClient.Id
                + ", idSalle = " + uneReservation.IdSalle.Id
                + ", prix = " + uneReservation.Prix
                + ", idTechnicien = " + uneReservation.IdTechnicien.Id
                + ", nbClient = " + uneReservation.NbClient
                + ", idTheme = " + uneReservation.IdTheme + ")";
            this.mydbal.Update(query);
        }

        public void Delete(Reservation uneReservation)
        {
            string query = "Reservation Where id = " + uneReservation.Id;
            this.mydbal.Delete(query);
        }
    }
}

