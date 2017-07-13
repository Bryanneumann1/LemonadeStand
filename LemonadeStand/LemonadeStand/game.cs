using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class game
    {
        rules Start = new rules();
        weather outside = new weather();
        store purchase = new store();
        store buy = new store();

        public game()
        {
           
           
        }
        public void playgame()
        {
            Start.DisplayRules();
            Console.ReadKey();
            outside.generateWeather();
            Console.ReadKey();
            purchase.displayinventoryrules();
            buy.purchaseinventory();
            

        }

    }
}
