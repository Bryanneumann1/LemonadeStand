using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ice
    {
        
        private double iceCost = .05;

        public double IceCost
        {
            get{ return iceCost; }
            set{ iceCost = value; }       }
    }
}
