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
        Store buy;
        Random random;



        public Game()
        {
            Start = new Rules();
            buy = new Store(player);
            random = new Random();


        }
        public void Playgame()
        {
            Start.DisplayRules();
            Console.ReadKey();
            outside.GenerateWeather(random);
            Console.ReadKey();
            buy.DisplayInventoryRules();
            buy.PurchaseInventory();

           
            
            //store.DisplayInventoryRules();
           // player.DisplayInventory();
            //store.PurchaseInventory();
            //player.DisplayInventory();

            for(int i = 0; i < 7; i++)
            {

            }
        }

    }
}
