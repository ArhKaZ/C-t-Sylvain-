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

        public viewModelCredits(DaoClient theDaoClient, DaoTransaction theDaoTransaction)
        {

        }
    }
}
