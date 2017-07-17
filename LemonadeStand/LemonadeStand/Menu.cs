using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Menu
    {
        static Player player = new Player();
        Store store = new Store(player);
        Recipe recipe = new Recipe();
        LemonadeStand lemonadeStand = new LemonadeStand();
        public void DisplayMenu()
        {
            Console.WriteLine("Please press (1) for the Main Menu\n" +
                "Please press (2) to go to the Store\n" +
                "Please press (3) to make your Recipe\n" +
                "Please press (4) to sell lemonade today");
            string menu = Console.ReadLine().ToLower();
            switch (menu)
            {
                case "1":
                    DisplayMenu();
                    break;
                case "2":
                    store.PurchaseInventory();
                    break;
                case "3":
                    recipe.SetRecipe();
                    break;
                case "4":
                    lemonadeStand.SellLemonade();
                    break;
                default:
                    DisplayMenu();
                    break;
            }
        }
    }
}
