using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Lemonade Stand");
            rules Start = new rules();
            Start.DisplayRules();
                
            Console.ReadKey();
        }
    }
}
