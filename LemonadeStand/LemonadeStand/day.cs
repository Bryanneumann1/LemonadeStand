using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public List<Customer> CustomerList = new List<Customer>();
        public int dayNumber;
        public double lemonadePrice;
        public double endOfDayTotal;
        public double people;
        public int pitcher;
        Weather weather;

        public Day()
        {
            Weather weather = new Weather();
            dayNumber = 1;
            pitcher = 10;
        }
        // public List<Customer> CreatCustomer (Weather weather)
        // {
        //     people = weather.
        //}
    }
}
