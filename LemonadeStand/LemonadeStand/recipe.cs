using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int numberOfPitchers;
        int sugarForRecipe = 15;
        int iceForRecipe = 20;
        int lemonsForRecipe = 8;
        public int removeLemons;
        public int removeIce;
        public int removeSugar;
        
        
        public Recipe()
        {

        }
        public void ChooseRecipe()
        {
            Console.WriteLine("You will have the option to use the standard recipe or create your own.\n" +
                "The standard recipe for lemonade is 20 ice cubes, 15 sugar cubes, and 8 lemons\n" +
                "This recipe makes 10 cups of lemonade.\n" +
                "Please enter (1) if you would like to use the standard recipe\n" +
                "Please enter (2) if you would like to make your own recipe\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    NumberOfPitchers();
                    break;
                case "2":
                    CreateOwnRecipeLemons();

                    CreateOwnRecipeIce();
                    CreateOwnRecipeSugar();
                    break;
                default:
                    ChooseRecipe();
                    break;
            }
        }
        public int NumberOfPitchers()
        {
            Console.WriteLine("How many pitchers would you like to make?\n" +
                "Keep in mind that any left over lemonade can not be used for the next day.");
            try
            {
                int numberOfPitchers = int.Parse(Console.ReadLine());
                return this.numberOfPitchers = numberOfPitchers;
            }
            catch (Exception)
            {
                Console.WriteLine("You may not have enough inventory to make that many pitchers");
                ChooseRecipe();
                throw;
            }
        }

        public int CreateOwnRecipeLemons()
        {
            Console.WriteLine("How many lemons would you like to use in your recipe?");
            try
            {
                int lemonsForRecipe = int.Parse(Console.ReadLine());
                return this.lemonsForRecipe = lemonsForRecipe;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number, Please try again.");
                CreateOwnRecipeLemons();
                throw;
            }
        }
        public int CreateOwnRecipeIce()
        {
            Console.WriteLine("How many ice cubes would you like to use in your recipe?");
            try
            {
                int iceForRecipe = int.Parse(Console.ReadLine());
                return this.iceForRecipe = iceForRecipe;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number, Please try again.");
                CreateOwnRecipeIce();
                throw;
            }
        }
        public int CreateOwnRecipeSugar()
        {
            Console.WriteLine("How many sugar cubes would you like to use in your recipe?");
            try
            {
                int sugarForRecipe = int.Parse(Console.ReadLine());
                return this.sugarForRecipe = sugarForRecipe;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number, Please try again.");
                CreateOwnRecipeSugar();
                throw;
            }
        }
        public int UseLemons()
        {
            try
            {
                removeLemons = numberOfPitchers * lemonsForRecipe;
                return removeLemons;
            }
            catch (Exception)
            {
                Console.WriteLine("Looks like you dont have enough lemons, Lets try again");
                ChooseRecipe();
                throw;
            }
        }
        public int UseIce()
        {
            try
            {
                removeIce = numberOfPitchers * iceForRecipe;
                return removeIce;
            }
            catch (Exception)
            {
                Console.WriteLine("Looks like you dont have enough Ice, Lets try again");
                ChooseRecipe();
                throw;
            }
        }
        public int UseSugar()
        {
            try
            {
                removeSugar = numberOfPitchers * sugarForRecipe;
                return removeSugar;
            }
            catch (Exception)
            {
                Console.WriteLine("Looks like you dont have enough lemons, Lets try again");
                ChooseRecipe();
                throw;
            }
        }
    }
}