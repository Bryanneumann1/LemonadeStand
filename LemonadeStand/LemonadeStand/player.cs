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
        public void GenereateIce(int numberOfItem)
        {
            for (int i = 0; i < numberOfItem; i++)
            {
                Ice ice = new Ice();
                inventory.ice.Add(ice);
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
                inventory.sugar.Add(sugar);
            }
        }
    }
}
