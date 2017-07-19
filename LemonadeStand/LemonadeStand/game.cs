using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Rules Start;
        Weather weather = new Weather();
        public Player player = new Player();
        Store store;
        Recipe recipe;
        Day day;
        Random random;
        Inventory inventory;


        public Game()
        {
            Start = new Rules();
            store = new Store(player);
            recipe = new Recipe();
            day = new Day();
            random = new Random();
            inventory = new Inventory();


        }
        public void Playgame()
        {
            Start.DisplayRules();
            weather.GenerateWeather(random);
            weather.GenerateTemp(random);
            store.DisplayInventoryRules();


            for (int i = 0; i < 7; i++)
            {
                store.PurchaseInventory();
                recipe.ChooseRecipe();
                day.MakeCustomer(weather, random);
                day.StartDay();
                day.CustomerTransaction(inventory, player);
            }
            Environment.Exit(0);
        }

    }
}
