using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int thirst;
        public double customerCash;

        public Customer(int thirst,double customerCash)
        {
            this.thirst = 0;
            this.customerCash = 0;

        }
        public int GetThirst(Random random)
        {
            int thirstiness = 0;
            thirstiness = random.Next(0, 4);
            return thirst;
        }
        public double GetCustomerCash(Random random)
        {
            double cash = 0;
            cash = random.Next(1, 15);
            return customerCash * .10;
        }
    }
}

