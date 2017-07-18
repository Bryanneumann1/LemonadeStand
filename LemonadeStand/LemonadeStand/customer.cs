using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        int thirst;
        double customerCash;

        public Customer()
        {
            thirst = 0;
            customerCash = 0;
        }
        public int GetThirst(Random random)
        {
            int thirstiness = 0;
            thirstiness = random.Next(0, 4);
            return thirstiness;
        }
        public double GetCustomerCash(Random random)
        {
            double cash = 0;
            cash = random.Next(1, 15);
            return cash * .10;
        }
    }
}

