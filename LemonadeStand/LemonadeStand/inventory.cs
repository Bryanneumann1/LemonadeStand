using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        List<Lemons> lemons = new List<Lemons>();
        List<Ice> ice = new List<Ice>();
        List<Sugar> sugar = new List<Sugar>();

        public void AddLemons(int lemonsneeded)
        {
           for (int i = 0; i < lemonsneeded; i++) ;
        }

    }
}
