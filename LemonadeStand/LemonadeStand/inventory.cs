using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class inventory
    {
        public int lemons;
        public int ice;
        public int sugar;

        public inventory()
        {
            lemons = 0;
            ice = 0;
            sugar = 0;

        }
        public void buyinventory()
        {
            Console.WriteLine("You will need to purchase your invintory\n" +
                "Make sure you have enough invintory to make it through the day\n" +
                "If you run out you will lose potential sales\n" +
                "But if you purchase to much, invintory may spoil");
        }
    }
}
