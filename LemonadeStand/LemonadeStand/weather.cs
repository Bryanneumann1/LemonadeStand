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
        public int generateWeather()
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
                Console.WriteLine("Looks like its cloudy out today, Should be a decent day to sell lemonade");
            }
            else if (number is 3)
            {
                Console.WriteLine("Looks like its windy today, good luck selling lemonade on such a windy day");
            }
            generateTemp();
            return number;
            
        }
        public int generateTemp()
        {
            Random tempature = new Random();
            int temp = tempature.Next(70, 99);
            Console.WriteLine("The current tempature for today is "+temp+" degrees\n" +
                "\n" +
                "Press Enter to go to the store.\n" +
                "");

            return temp;
        }

    }

}
