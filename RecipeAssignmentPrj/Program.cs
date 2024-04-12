using RecipeAssignmentPrj;
using System;







class Program
{
    static void Main(string[] args)
    {
        Recipe recipe = null;
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Create New Recipe");
            Console.WriteLine("2. Display Recipe");
            Console.WriteLine("3. Display Ingredient Quantities");
            Console.WriteLine("4. Reset Ingredients");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the number of ingredients:");
                    int ingredientCount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number of steps:");
                    int stepCount = int.Parse(Console.ReadLine());
                    recipe = new Recipe(ingredientCount, stepCount);

                    for (int i = 0; i < ingredientCount; i++)
                    {
                        Console.WriteLine($"Enter details for ingredient {i + 1}:");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Quantity (NB: Quantity must be a number): ");
                        double quantity;
                        while (!double.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive number.");
                        }
                        Console.Write("Unit: ");
                        string unit = Console.ReadLine();

                        recipe.SetIngredientDetails(i, name, quantity, unit);
                    }

                    Console.WriteLine("Details successfully captured.");
                    break;

                case "2":
                    if (recipe != null)
                    {
                        Console.WriteLine("\nRecipe Details:");
                        recipe.DisplayRecipe();
                    }
                    else
                    {
                        Console.WriteLine("Please create a recipe first.");
                    }
                    break;

                case "3":
                    if (recipe != null)
                    {
                        recipe.DisplayIngredientQuantities();
                    }
                    else
                    {
                        Console.WriteLine("Please create a recipe first.");
                    }
                    break;

                case "4":
                    if (recipe != null)
                    {
                        recipe.ResetIngredients();
                    }
                    else
                    {
                        Console.WriteLine("Please create a recipe first.");
                    }
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

