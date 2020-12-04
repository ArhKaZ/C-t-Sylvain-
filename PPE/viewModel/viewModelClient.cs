using System;
using System.Windows.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
        private Client leCli = new Client();

        public ObservableCollection<Client> ListClient { get => listClient; set => listClient = value; }
        public Client Client
        {
            get => leCli;
            set
            {
                if (leCli != value)
                {
                    leCli = value;
                    OnPropertyChanged("Client");
                    OnPropertyChanged("Nom");
                    OnPropertyChanged("Prenom");
                    OnPropertyChanged("Telephone");
                    OnPropertyChanged("Mail");
                    OnPropertyChanged("Credit");
                    OnPropertyChanged("DateNaissance");
                    OnPropertyChanged("Photo");
                    OnPropertyChanged("NbPartie");
                }
            }
        }
        public viewModelClient(DaoClient theDaoClient)
        {
            vmDaoClient = theDaoClient;
            listClient = new ObservableCollection<Client>(theDaoClient.SelectAll());  
        }

        public string Nom
        {
            get => leCli.Nom;
            set
            {
                if (leCli.Nom != value)
                {
                    leCli.Nom = value;
                    OnPropertyChanged("Nom");
                    
                }
            }
        }

        public MouseBinding SetNull
        {
            set
            {
                leCli = null;
            }
        }
        public string Prenom
        {
            get => leCli.Prenom;
            set
            {
                if (leCli.Prenom != value)
                {
                    leCli.Prenom = value;
                    OnPropertyChanged("Prenom");
                }
            }
        }

        public int Telephone
        {
            get => leCli.Telephone;
            set
            {
                if (leCli.Telephone != value)
                {
                    leCli.Telephone = value;
                    OnPropertyChanged("Telephone");
                }
            }
        }

        public string Mail
        {
            get => leCli.Mail;
            set
            {
                if (leCli.Mail != value)
                {
                    leCli.Mail = value;
                    OnPropertyChanged("Mail");
                }
            }
        }

        public int Credit
        {
            get => leCli.Credit;
            set
            {
                if (leCli.Credit != value)
                {
                    leCli.Credit = value;
                    OnPropertyChanged("Credit");
                }
            }
        }

        public DateTime DateNaissance
        {
            get => leCli.DateNaissance;
            set
            {
                if (leCli.DateNaissance != value)
                {
                    leCli.DateNaissance = value;
                    OnPropertyChanged("DateNaissance");
                }
            }
        }

        public string Photo
        {
            get => leCli.Photo;
            set
            {
                if (leCli.Photo != value)
                {
                    leCli.Photo = value;
                    OnPropertyChanged("Photo");
                }
            }
        }

        public int NbPartie
        {
            get => leCli.Nbpartie;
            set
            {
                if (leCli.Nbpartie != value)
                {
                    leCli.Nbpartie = value;
                    OnPropertyChanged("NbPartie");
                }
            }
        }
        public ICommand UpdateCommand
        {
            get
            {
                if (this.updateCommand == null)
                {
                    this.updateCommand = new RelayCommand(() => UpdateClient(), () => true);
                }
                return this.updateCommand;

            }

        }
        public ICommand InsertCommand
        {
            get
            {
                if (this.insertCommand == null)
                {
                    this.insertCommand = new RelayCommand(() => InsertClient(), () => true);
                }
                return this.insertCommand;

            }

        }
        public ICommand DeleteCommand
        {
            get
            {
                if (this.deleteCommand == null)
                {
                    this.deleteCommand = new RelayCommand(() => DeleteClient(), () => true);
                }
                return this.deleteCommand;

            }

        }

        private void UpdateClient()
        {
            Client Clientsauv = new Client();
            vmDaoClient.Update(Client);
            int index = listClient.IndexOf(Client);
            Clientsauv = Client;
            listClient.Insert(index, Client);
            listClient.RemoveAt(index + 1);
            Client = Clientsauv;
        }
        
        private void InsertClient()
        {
            int idf = 0;
            vmDaoClient.Insert(Client);
            foreach (Client c in listClient)
            {
                idf = idf + 1;
            }

            listClient.Add(Client);
        }

        private void DeleteClient()
        {
            int index = listClient.IndexOf(Client);
            vmDaoClient.Delete(leCli);
            listClient.Remove(Client);
        }
    }
}
