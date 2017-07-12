using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class weather
    {
        public weather()
        {

        }
        public int generateweather()
        {
            Random weather = new Random();
            int number = weather.Next(0, 3);
            if (number is 0)
            {
                Console.WriteLine("Looks like its raining today, good luck selling lemonade in the rain");
            }
            else if (number is 1)
            {
                Console.WriteLine("Looks like its sunny out today, Should be a nice day to sell lemonade");
            }
            else if (number is 2)
            {
                Console.WriteLine("Looks like its cloudy out today, Should be a decient day to sell lemonade");
            }
            else if (number is 3)
            {
                Console.WriteLine("Looks like its windy today, good luck selling on such a windy day");
            }
            return number;
        }
    }
}
