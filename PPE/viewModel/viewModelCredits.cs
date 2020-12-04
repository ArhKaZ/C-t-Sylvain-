using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using ModelLayer.Business;
using ModelLayer.Data;
namespace PPE.viewModel
{
    class viewModelCredits : viewModelBase
    {
        private DaoClient theDaoClient;
        private DaoTransaction theDaoTransaction;
        private ICommand insertCommand;
        private ICommand updateCommand;
        private ICommand deleteCommand;
        private ObservableCollection<Client> listClient;
        private ObservableCollection<Transaction> listTransaction;
        private Client leCli = new Client();
        private Transaction laTransaction = new Transaction();
        
        //Public
        public ObservableCollection<Client> ListClient { get => listClient; set => listClient = value; }
        public ObservableCollection<Transaction> ListTransaction { get => listTransaction; set => listTransaction = value; }

        public Transaction Transaction { }

        public Client Client
        {
            get => leCli;
            set
            {
                if (leCli != value) { }

            }
        }
        //public string Operation
        //{
        //    get => laTransaction.Operation;
        //    set
        //    {
        //        if (laTransaction.Operation != value)
        //        {
        //            laTransaction.Operation = value;
        //            OnPropertyChanged("")
        //        }
        //    }
        //}

        public viewModelCredits(DaoClient theDaoClient, DaoTransaction theDaoTransaction)
        {

        }
    }
}
