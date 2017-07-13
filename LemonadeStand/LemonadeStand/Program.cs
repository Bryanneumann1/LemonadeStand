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
            game start = new game();
            start.playgame();
                
            Console.ReadKey();
        }
    }
}
