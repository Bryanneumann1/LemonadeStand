using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   
    public class Store
    {
       
        public double PurchaseLemons;
        public double PurchaseIce;
        public double PurchaseSugar;
        Player player;
        bool enoughMoney;




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
                    BuyLemons();
                    break;
                case "ice":
                    BuyIce();
                    break;
                case "sugar":
                    BuySugar();
                    break;
                case "done":
                    break;
                default:
                    PurchaseInventory();
                    break;
            }

        }
        public int NumberOfLemonsNeeded()
        {
            Console.WriteLine("Lemons cost {0} each",player.inventory.lemon.LemonCost);
            Console.WriteLine("How many lemons would you like to purchase?\n");
            int lemonsNeeded = 0;
            try
            {
                lemonsNeeded = int.Parse(Console.ReadLine());

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
            Console.WriteLine("Sugar costs {0} each",player.inventory.sugar.SugarCost);
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
            Console.WriteLine("Ice costs {0} each",player.inventory.ice.IceCost);
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
        public void BuyLemons()
        {
            int numberOfLemons = NumberOfLemonsNeeded();
                    Lemons lemons = new Lemons();

                    enoughMoney = player.CheckIfEnoughMoney(numberOfLemons, lemons.LemonCost);
                    if (enoughMoney == true)
                    {
                        player.GenerateLemons(numberOfLemons);
                        PurchaseLemons = (numberOfLemons) * lemons.LemonCost;
                        player.wallet.money = player.wallet.money - PurchaseLemons;
                    }
                    player.DisplayInventory();
                    PurchaseInventory();
        }
        public void BuyIce()
        {
            int numberOfIce = NumberOfIceNeeded();
            Ice ice = new Ice();
            enoughMoney = player.CheckIfEnoughMoney(numberOfIce, ice.IceCost);
            if (enoughMoney == true)
            {
                player.GenerateIce(numberOfIce);
                PurchaseIce = (numberOfIce) * ice.IceCost;
                player.wallet.money = player.wallet.money - PurchaseIce;

            }
            else
            {
                numberOfIce = NumberOfIceNeeded();
            }
            player.DisplayInventory();
            PurchaseInventory();
        }
        public void BuySugar()
        {
            int numberOfSugar = NumberOfSugarNeeded();
            Sugar sugar = new Sugar();
            enoughMoney = player.CheckIfEnoughMoney(numberOfSugar, sugar.SugarCost);
            if (enoughMoney == true)
            {
                player.GenerateSugar(numberOfSugar);
                PurchaseSugar = (numberOfSugar) * sugar.SugarCost;
                player.wallet.money = player.wallet.money - PurchaseSugar;
            }
            player.DisplayInventory();
            PurchaseInventory();
        }
    }
}
