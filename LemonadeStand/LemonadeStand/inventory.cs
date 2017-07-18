using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemons> lemons = new List<Lemons>();
        public List<Ice> icecubes = new List<Ice>();
        public List<Sugar> sugarcubes = new List<Sugar>();
        public Lemons lemon = new Lemons();
        public Ice ice = new Ice();
        public Sugar sugar = new Sugar();

        public void AddLemons(int LemonsNeeded)
        {
            for (int i = 0; i < LemonsNeeded; i++)
            {

                lemons.Add(new Lemons());
            }
            
        }
        public void AddSugar(int SugarNeeded)
        {
            for (int i = 0; i < SugarNeeded; i++)
            {

                sugarcubes.Add(sugar);

            }

        }
        public void AddIce(int IceNeeded)
        {
            for (int i = 0; i < IceNeeded; i++)
            { 
                icecubes.Add(ice);
            }
        }
        public void RemoveLemons(Player player)
        {
            try
            {
                int numberOfLemonsToRemove = player.recipe.removeLemons;
                for (int i = 0; i < numberOfLemonsToRemove; i++)
                {
                    lemons.RemoveAt(0);

                }
            }
            catch (Exception)
            {
                Console.WriteLine("You may need to modify your recipe" );
                player.recipe.ChooseRecipe();
            }
        }
        public void RemoveIce(Player player)
        {
            try
            {
                int numberOfIceToRemove = player.recipe.removeIce;
                for (int i = 0; i < numberOfIceToRemove; i++)
                {
                    icecubes.RemoveAt(0);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You may need to modify your recipe");
                player.recipe.ChooseRecipe();
            }
        }
        public void RemoveSugar(Player player)
        {
            try
            {
                int numberOfSugarToRemove = player.recipe.removeSugar;
                for (int i = 0; i < numberOfSugarToRemove; i++)
                {
                    sugarcubes.RemoveAt(0);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You may need to modify your recipe");
                player.recipe.ChooseRecipe();
            }
        }
    }
}
