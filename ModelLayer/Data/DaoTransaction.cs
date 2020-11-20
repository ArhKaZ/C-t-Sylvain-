using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Business;
namespace ModelLayer.Data
{
    class DaoTransaction
    {
        private Dbal mydbal;
        private DaoTransaction theDaoTransaction;

        public DaoTransaction(Dbal mydbal, DaoTransaction theDaoTransaction)
        {
            this.mydbal = mydbal;
            this.theDaoTransaction = theDaoTransaction;
        }

        public void Insert(Transaction uneTransac)
        {
            string query = "Transaction (id, operation, montant, reservation, idclient) VALUES ("
                + uneTransac.Id + ",'"
                + uneTransac.Operation + "',"
                + uneTransac.Montant + ","
                + uneTransac.Reservation.Id + ","
                + uneTransac.IdClient.Id + ")";
            this.mydbal.Insert(query);
        }

        public void Update(Transaction uneTransac)
        {
            string query = "Transaction set id = " + uneTransac.Id
                + ", operation = '" + uneTransac.Operation
                + ", montant = " + uneTransac.Montant
                + ", reservation = " + uneTransac.Reservation.Id
                + ", idClient = " + uneTransac.IdClient.Id + ")";
            this.mydbal.Update(query);
        }

        public void Delete(Transaction uneTransac)
        {
            string query = "Transaction Where id = " + uneTransac.Id + ")";
            this.mydbal.Delete(query);
        }
    }
}
