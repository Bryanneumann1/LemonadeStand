﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class store
    {
        public double lemons;
        public double ice;
        public double sugar;

        public store()
        {
            lemons = 00.10;
            ice = 00.05;
            sugar = 00.05;
        }
        public void displayinventoryrules()
        {
            Console.WriteLine("You will need to purchase your inventory\n" +
                "Make sure you have enough inventory to make it through the day\n" +
                "If you run out you will lose potential sales\n");
        }  
        public void purchaseinventory()
        {
            Console.WriteLine("Would you like to purchase (lemons), (ice), or (sugar)? When your done purchasing type (done)");
            string inventory = Console.ReadLine();

            if (inventory is "lemons")
            {
                Console.WriteLine("Each lemon costs $00.10, How many lemons would you like to purchase?");
                    Console.ReadLine();
            }

        }

        
 
    }
}
