﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Rules Start;
        Weather outside = new Weather();
        public Player player = new Player();
        Store store;
        Menu menu;
       

        public Game()
        {
            Start = new Rules();
            store = new Store(player);
            menu = new Menu();

        }
        public void Playgame()
        {
            Start.DisplayRules();
            Console.ReadKey();
            outside.GenerateWeather();
            menu.DisplayMenu();
            store.DisplayInventoryRules();
            player.DisplayInventory();
            store.PurchaseInventory();
            player.DisplayInventory();

        }

    }
}
