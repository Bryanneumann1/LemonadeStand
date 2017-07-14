using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        double PurchaseLemons;
        double PurchaseIce;
        double PurchaseSugar;

        public void DisplayInventoryRules()
        {
            Console.WriteLine("You will need to purchase your inventory\n" +
                "Make sure you have enough inventory to make it through the day\n" +
                "If you run out you will lose potential sales\n");
        }
        public void PurchaseInventory()
        {
            Console.WriteLine("Would you like to purchase (lemons), (ice), or (sugar)? When your done purchasing type (done)");
            string inventory = Console.ReadLine().ToLower();
            switch (inventory)
            {
                case "lemons":
                   NumberOfLemonsNeeded();
                    break;
                case "ice":
                   NumberOfIceNeeded();
                    break;
                case "sugar":
                   NumberOfSugarNeeded();
                    break;
                case "done":

                default:
                    Console.WriteLine("please enter (lemons), (ice), or (sugar)? When your done purchasing type (done)");
                    PurchaseInventory();
                    break;
            }
        }
        public int NumberOfLemonsNeeded()
        {
            Console.WriteLine("Lemons cost 20 cents each.\n");
            Console.WriteLine("How many lemons would you like to purchase?\n");
            try
            {
                int lemonsNeeded = int.Parse(Console.ReadLine());
                return lemonsNeeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the quantity in numerical form.\n");
                PurchaseInventory();
                throw;
            }
        }
        public int NumberOfSugarNeeded()
        {
            Console.WriteLine("Sugar costs 10 cents per sugar cube.\n");
            Console.WriteLine("How many sugar cubes would you like to purchase?\n");
            try
            {
                int sugarneeded = int.Parse(Console.ReadLine());
                return sugarneeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the quantity in numerical form.\n");
                PurchaseInventory();
                throw;
            }
        }
        public int NumberOfIceNeeded()
        {
            Console.WriteLine("Ice costs 5 cents per cube.\n");
            Console.WriteLine("How many ice cubes would you like to purchase?\n");
            try
            {
                int iceneeded = int.Parse(Console.ReadLine());
                return iceneeded;
            }
            catch
            {
                Console.WriteLine("Please enter the quantity in numerical form.\n");
                PurchaseInventory();
                throw;
            }
        }
    }
}
