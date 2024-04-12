using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAssignmentPrj
{
    class Recipe
    {
        private Ingredients[] Ingredients;
        private Step[] Steps;

        public Recipe(int ingredientCount, int stepCount)
        {
            Ingredients = new Ingredients[ingredientCount];
            for (int i = 0; i < ingredientCount; i++)
            {
                Ingredients[i] = new Ingredients("", 0, ""); 
            }

            Steps = new Step[stepCount];
            for (int i = 0; i < stepCount; i++)
            {
                Steps[i] = new Step(""); 
            }
        }
       
        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredients in Ingredients)
            {
                Console.WriteLine($"{ingredients.Quantity} {ingredients.Unit} {ingredients.Name}");
            }
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }

        public void DisplayIngredientQuantities()
        {
            Console.WriteLine("Ingredient Quantities:");
            foreach (var ingredients in Ingredients)
            {
                Console.WriteLine($"{ingredients.Quantity} {ingredients.Unit}");
            }
        }

        public void ResetIngredients()
        {
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Ingredients[i].Quantity = 0; 
            }
            Console.WriteLine("Ingredients reset to original quantities.");
        }

        public void SetIngredientDetails(int index, string name, double quantity, string unit)
        {
            Ingredients[index] = new Ingredients(name, quantity, unit);
        }

        public void SetStepDescription(int index, string description)
        {
            Steps[index] = new Step(description);
        }
    }
}
