using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public Recipe()
        {

        }
        public void ChooseRecipe()
        {
            Console.WriteLine("You will have the option to use the standard recipe or create your own.\n" +
                "The standard recipe for lemonade is 5 ice cubes, 5 sugar cubes, and 2 lemons\n" +
                "Please enter (1) if you would like to use the standard recipe\n" +
                "Please enter (2) if you would like to make your own recipe");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    UseDefaultRecipe();
                    break;
                case "2":
                    CreateOwnRecipe();
                    break;
                default:
                    ChooseRecipe();
                    break;
            }
        }
        public void UseDefaultRecipe()
        {
            Console.WriteLine("default");
        }

        public void CreateOwnRecipe()
        {
            Console.WriteLine("own");
        }







    }
}