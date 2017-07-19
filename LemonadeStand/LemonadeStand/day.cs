using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Day
    {
        public List<Customer> CustomerList = new List<Customer>();
        public int dayNumber;
        public double lemonadePrice;
        public double endOfDayTotal;
        public double people;
        public int pitcher;
        public Customer customer;
        Inventory inventory;

        public Day()
        {
            inventory = new Inventory();
        
            dayNumber = 1;
            pitcher = 10;
            customer = new Customer(0,0);
        }
        public void DayCounter()
        {
            dayNumber += 1;
        }
        public void MakeCustomer(Weather weather, Random random)
        {
            double people = weather.temp * .50;
             
            for (int i = 0; i < people; i++)
            

            { 
                customer.thirst = customer.GetThirst(random);
                customer.customerCash = customer.GetCustomerCash(random);
                CustomerList.Add(new Customer(customer.thirst,customer.customerCash));
               Console.WriteLine("Test for thirst and cash"+customer.thirst + customer.customerCash);
            }
        }
        public void StartDay()
        {
            Console.WriteLine("Now that your ready, it's time to sell some lemonade");
            Console.WriteLine("How much would you like to charge for a cup of lemonade?");
            string input = Console.ReadLine();
            if (input != null)
            {
                lemonadePrice = double.Parse(input);
            }
            else
            {
                StartDay();
            }
            Console.WriteLine("You set each cup to a price of ${0}",lemonadePrice);
        }
        public void CustomerTransaction(Inventory inventory, Player player)
        {

            int customerCapabilityToBuy = 0;

            foreach (Customer customer in CustomerList)
            {
                if (customer.customerCash >= lemonadePrice && customer.thirst > 1)
                {
                    customerCapabilityToBuy++;
                }
            }

            if (customerCapabilityToBuy == 0)
            {
                Console.WriteLine("Sorry, no more customers want to buy your Lemonade. Go home.");
            }
            else if (customerCapabilityToBuy != 0)
            {
                if (inventory.lemons.Count >= 1 && inventory.sugarcubes.Count >= 1 && inventory.icecubes.Count >= 3)
                {
                    inventory.UpdateInventory();
                    while (customerCapabilityToBuy >= pitcher)
                    {
                        endOfDayTotal = player.wallet.money + (lemonadePrice * pitcher);
                        customerCapabilityToBuy -= pitcher;
                        for (int i = 0; i < pitcher; i++)
                        {
                            CustomerList.RemoveAt(0);
                        }
                        if (inventory.lemons.Count >= 1 && inventory.sugarcubes.Count >= 1 && inventory.icecubes.Count >= 3)
                        {
                            inventory.UpdateInventory();
                        }
                        else
                        {
                            customerCapabilityToBuy = 0;
                        }
                    }
                    player.wallet.money += (lemonadePrice * customerCapabilityToBuy);
                    for (int i = 0; i < customerCapabilityToBuy; i++)
                    {
                        CustomerList.RemoveAt(0);
                    }
                    Console.WriteLine("Total amount in your wallet at the end of today is ${0}.", endOfDayTotal);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Not enough inventory to make Lemonade.");
                    Console.ReadLine();
                }
            }
        }
    }
}
