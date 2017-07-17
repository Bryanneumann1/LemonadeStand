using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double money;
        double transaction;
        

        public Wallet()
        {
            money = 20.00;
        }

        public double BuyItems(double costOfItems)
        {
            transaction = money - costOfItems;
            Console.WriteLine("Transaction complete");
            money = transaction;
            return money;
        }
        public void TotalEarnings()
        {
            double earnings;
            double startingMoney = 20.00;
            earnings = money - startingMoney;
            Console.WriteLine("You made {0} this week!",earnings);
        }
    }
}
