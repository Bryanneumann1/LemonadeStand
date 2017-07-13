using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        double buyLemons;
        double buyIceCubes;
        double buySugar;
        

        public Store()
        {
          
        }
        public void displayinventoryrules()
        {
            Console.WriteLine("You will need to purchase your inventory\n" +
                "Make sure you have enough inventory to make it through the day\n" +
                "If you run out you will lose potential sales\n");
        }  
        public void Purchaseinventory()
        {
            Console.WriteLine("Would you like to purchase (lemons), (ice), or (sugar)? When your done purchasing type (done)");
            string inventory = Console.ReadLine().ToLower();
            switch (inventory)
            {
                case "lemons":
                    buylemons(player);
                    break;
                case "ice":
                    buyice(player);
                    break;
                case "sugar":
                    buysugar(player);
                    break;
                case "done":

                default:
                    Console.WriteLine("please enter (lemons), (ice), or (sugar)? When your done purchasing type (done)");
                    Purchaseinventory();
                    break;

            }

            

                
            
       

        }

        
 
    }
}
