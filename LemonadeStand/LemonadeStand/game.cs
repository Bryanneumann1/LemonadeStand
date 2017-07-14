using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Rules Start;
        Weather outside = new Weather();
        public Player player = new Player();
        Store store;
        public Game()
        {
            Start = new Rules();
            store = new Store(player);
        }
        public void Playgame()
        {
            Start.DisplayRules();
            Console.ReadKey();
            outside.GenerateWeather();
            Console.ReadKey();
            store.DisplayInventoryRules();
            store.PurchaseInventory();
            

        }

    }
}
