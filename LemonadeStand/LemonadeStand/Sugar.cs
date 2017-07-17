using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar
    {
        private double sugarcost = .05;

        public double SugarCost
        {
            get{ return sugarcost; }
            set{ sugarcost = value; }       }
    }
}
