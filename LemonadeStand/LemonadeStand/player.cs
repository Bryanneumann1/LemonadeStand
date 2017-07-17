using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Wallet wallet = new Wallet();
        public Inventory inventory = new Inventory();
        public Recipe recipe = new Recipe();
        public bool CheckIfEnoughMoney(int numberOfItem, double priceOfItem)
        {
            double costOfItems = numberOfItem * priceOfItem;
            if (costOfItems > wallet.money)
            {
                Console.WriteLine("Not enough money");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void GenerateIce(int numberOfItem)
        {
            for (int i = 0; i < numberOfItem; i++)
            {
                Ice ice = new Ice();
                inventory.icecubes.Add(ice);
            }
        }
        public void GenerateLemons(int numberOfItem)
        {
            for (int i = 0; i < numberOfItem; i++)
            {
                Lemons lemon = new Lemons();
                inventory.lemons.Add(lemon);
            }
        }

        public void GenerateSugar(int numberOfItem)
        {
            for (int i = 0; i < numberOfItem; i++)
            {
                Sugar sugar = new Sugar();
                inventory.sugarcubes.Add(sugar);
            }
        }
        public void DisplayInventory()
        {
            Console.WriteLine("You currently have {0} ice cubes.\n", inventory.icecubes.Count);
            Console.WriteLine("You currently have {0} sugar cubes.\n", inventory.sugarcubes.Count);
            Console.WriteLine("You currently have {0} lemons.\n", inventory.lemons.Count);
            Console.WriteLine("You currently have {0} in your wallet.\n", wallet.money);
        }

    }
}
