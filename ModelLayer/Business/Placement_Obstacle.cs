using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Business
{
    class Placement_Obstacle
    {
        private int _num_placement;
        private int _reservation;
        private int _obstacle;

        public Placement_Obstacle(int num_placement, int reservation, int obstacle)
        {
            _num_placement = num_placement;
            _reservation = reservation;
            _obstacle = obstacle;
        }
        
        public Placement_Obstacle(){}

        public int num_placement { get => _num_placement; set => _num_placement = value; }
        public int reservation { get => _reservation; set => _reservation = value; }
        public int obstalce { get => _obstacle; set => _obstacle = value; }
    }
}
