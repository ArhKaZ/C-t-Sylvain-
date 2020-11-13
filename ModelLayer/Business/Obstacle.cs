using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Business
{
    class Obstacle
    {
        private int _id;
        private string _nom;
        private string _photo;
        private string _commentaire;
        private int _difficulte;
        private int _prix;
        private int _theme;

        public Obstacle(int id, string nom, string photo, string commentaire, int difficulte, int prix, int theme)
        {
            _id = id;
            _nom = nom;
            _photo = photo;
            _commentaire = commentaire;
            _difficulte = difficulte;
            _prix = prix;
            _theme = theme;
        }

        public int id { get => _id; set => _id = value; }
        public string photo { get => _photo; set => _photo = value; }
        public string commentaire { get => _commentaire; set => _commentaire = value; }
        public int difficulte { get => _difficulte; set => _difficulte = value; }
        public int prix { get => _prix; set => _prix = value; }
        public int theme { get => _theme; set => _theme = value; }
    }
}
