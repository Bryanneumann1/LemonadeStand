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
        Player player;
        public Store(Player player)
        {
            this.player = player;
        }
        public void DisplayInventoryRules()
        {
            Console.WriteLine("You will need to purchase your inventory\n" +
                "Make sure you have enough inventory to make it through the day\n" +
                "If you run out you may lose potential sales\n");
        }
        public void PurchaseInventory()
        {
            Console.WriteLine("Would you like to purchase (lemons), (ice), or (sugar)? When your done purchasing type (done)");
            string inventory = Console.ReadLine().ToLower();
            switch (inventory)
            {
                case "lemons":
                    int numberOfLemons = NumberOfLemonsNeeded();
                    Lemons lemons = new Lemons();
                    bool enoughMoney = player.CheckIfEnoughMoney(numberOfLemons, lemons.GetCost());
                    if (enoughMoney == true)
                    {
                        player.GenerateLemons(numberOfLemons);
                        //take money from wallet
                    }
                    NumberOfLemonsNeeded();
                    break;
                case "ice":
                    int numberOfIce = NumberOfIceNeeded();
                    Ice ice = new Ice();
                    bool enoughMoney = player.CheckIfEnoughMoney(numberOfIce, ice.GetCost());
                    if (enoughMoney == true)
                    {
                        player.GenereateIce(numberOfIce);
                        //take money from wallet
                    }
                    else
                    {
                        numberOfIce = NumberOfIceNeeded();
                    }
                    break;
                case "sugar":
                    int numberOfSugar = NumberOfSugarNeeded();
                    Sugar sugar = new Sugar();
                    bool enoughMoney = player.CheckIfEnoughMoney(numberOfSugar, sugar.GetCost());
                    if (enoughMoney == true)
                    {
                        player.GenerateSugar(numberOfSugar);
                        //take money from wallet
                    }

                    break;
                case "done":

                default:
                    Console.WriteLine("Please enter (lemons), (ice), or (sugar)? When your done purchasing type (done)");
                    PurchaseInventory();
                    break;
            }

        }
        public int NumberOfLemonsNeeded()
        {
            Console.WriteLine("Lemons cost 20 cents each.\n");
            Console.WriteLine("How many lemons would you like to purchase?\n");
            int lemonsNeeded = 0;
            try
            {
                int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the quantity in numerical form.\n");
                PurchaseInventory();

            }
            return lemonsNeeded;
        }
        public int NumberOfSugarNeeded()
        {
            Console.WriteLine("Sugar costs 10 cents per sugar cube.\n");
            Console.WriteLine("How many sugar cubes would you like to purchase?\n");
            int sugarneeded = 0;
            try
            {
                sugarneeded = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the quantity in numerical form.\n");
                PurchaseInventory();

            }
            return sugarneeded;
        }
        public int NumberOfIceNeeded()
        {
            Console.WriteLine("Ice costs 5 cents per cube.\n");
            Console.WriteLine("How many ice cubes would you like to purchase?\n");
            int iceneeded = 0;
            try
            {
                iceneeded = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the quantity in numerical form.\n");
                PurchaseInventory();

            }
            return iceneeded;
        }

        public double NumberOfLemonsPurchased()
        {
            return PurchaseLemons;
        }
    }
}
