using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Business
{
    class Client
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private int _telephone;
        private string _mail;
        private int _credit;
        private DateTime _dateNaissance;
        private string _photo;
        private int _nbpartie;

        public Client(int id, string prenom, string nom, int telephone, string mail, int credit, DateTime dateNaissance, string photo, int nbpartie)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _telephone = telephone;
            _mail = mail;
            _credit = credit;
            _dateNaissance = dateNaissance;
            _photo = photo;
            _nbpartie = nbpartie;
        }
        
        public Client(){}

        public int id { get => _id; set => _id = value; }
        public string prenom { get => _prenom; set => _prenom = value; }
        public string nom { get => _nom; set => _nom = value; }
        public int telephone { get => _telephone; set => _telephone = value; }
        public string mail { get => _mail; set => _mail = value; }
        public int credit { get => _credit; set => _credit = value; }
        public DateTime dateNaissance { get => _dateNaissance; set => _dateNaissance = value; }
        public string photo { get => _photo; set => _photo = value; }
        public int nbpartie { get => _nbpartie; set => _nbpartie = value; }
    }
}
