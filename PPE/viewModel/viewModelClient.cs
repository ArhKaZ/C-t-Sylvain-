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
    class viewModelClient : viewModelBase
    {
        private DaoClient vmDaoClient;
        private ICommand insertCommand;
        private ICommand updateCommand;
        private ICommand deleteCommand;
        private ObservableCollection<Client> listClient;

        public viewModelClient(DaoClient theDaoClient)
        {
            vmDaoClient = theDaoClient;
            listClient = new ObservableCollection<Client>(theDaoClient.SelectAll());
            //foreach (Client c in listClient)
            //{
                
            //}
        }
    }
}
