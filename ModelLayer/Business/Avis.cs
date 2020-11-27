using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Business
{
    class Avis
    {
        private int _id;
        private int _idClient;
        private int _note;
        private string _commentaire;
        private int _idTheme;

        public Avis(int id, int idClient, int note, string commentaire, int idTheme)
        {
            _id = id;
            _idClient = idClient;
            _note = note;
            _commentaire = commentaire;
            _idTheme = idTheme;
        }
        
        public Avis(){}

        public int id { get => _id ; set => _id = value; }
        public int idClient { get => _idClient ; set => _idClient = value ; }
        public int note { get => _note; set => _note = value; }
        public string commentaire { get => _commentaire; set => _commentaire = value; }
        public int idTheme { get => _idTheme; set => _idTheme = value; }
    }
}
