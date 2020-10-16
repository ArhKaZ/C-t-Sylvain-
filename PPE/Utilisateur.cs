using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Utilisateur
    {
        public int id { get; set; }
        public char roleUser { get; set; }
        public int idVille { get; set; }
        public string identifiant { get; set; }
        public string mdp { get; set; }
    }
}
