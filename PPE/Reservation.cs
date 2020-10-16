using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Reservation
    {
        public DateTime dateRes { get; set; }
        public int id { get; set; }
        public int idClient { get; set; }
        public int idSalle { get; set; }
        public int prix { get; set; }
        public int idTechnicien { get; set; }
        public int nbClient { get; set; }
        public int idTheme { get; set; }
    }
}
