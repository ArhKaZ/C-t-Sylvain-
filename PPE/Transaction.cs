using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Transaction
    {
        public int id { get; set; }
        public char operation { get; set; }
        public int montant { get; set; }
        public int reservation { get; set; }
        public int idClient { get; set; }
    }
}
