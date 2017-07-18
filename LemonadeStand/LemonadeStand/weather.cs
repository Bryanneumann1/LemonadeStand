using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public Weather()
        {

        }
        public int GenerateWeather(Random random)
        {

            int number = random.Next(0, 3);
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
                Console.WriteLine("Looks like its cloudy out today, Should be a decent day to sell lemonade");
            }
            else if (number is 3)
            {
                Console.WriteLine("Looks like its windy today, good luck selling lemonade on such a windy day");
            }
            GenerateTemp(random);
            return number;
            
        }
        public int GenerateTemp(Random random)
        {

            int temp = random.Next(70, 99);
            Console.WriteLine("The current tempature today is " + temp + " degrees\n");
               

            return temp;
        }

    }

}
