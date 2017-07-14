using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Rules Start = new Rules();
        Weather outside = new Weather();
        Store purchase = new Store();
        Store buy = new Store();

        
        public void Playgame()
        {
            Start.DisplayRules();
            Console.ReadKey();
            outside.generateWeather();
            Console.ReadKey();
            purchase.DisplayInventoryRules();
            buy.PurchaseInventory();
            

        }

    }
}
