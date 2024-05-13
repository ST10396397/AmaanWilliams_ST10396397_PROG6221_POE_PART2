// See https://aka.ms/new-console-template for more information
using AmaanWilliams_ST10396397_PROG6221_POE_PART2;

class program
{
    static List <Recipe> recipes = new List <Recipe> ();

    static void Main(string[] args)
    {
        //Display options for the menu
        while (true)
        {
            Console.WriteLine("\u001b[32m\nRecipe Book:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Enter a new recipe ");
            Console.WriteLine("2. Display all recipes");
            Console.WriteLine("3. Display a recipe");
            Console.WriteLine("4. Scale a reccipe");
            Console.WriteLine("5. Clear all recipe");
            Console.WriteLine("6. Exit");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("-------------------------------------");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    EnterNewRecipe();
                    break;
                case 2:
                    DisplayAllRecipe();
                    break;
                case 3:
                    DisplayRecipe();
                    break;
                case 4:
                    ScaleRecipe();
                    break;
                case 5:
                    ClearAllRecipe();
                    break;
                //used to exit the program
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select another number");
                    break;
            }

        }
    }
    //option 1 the enter a new recipe
    static void EnterNewRecipe()
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Enter recipe name: ");
        String name = Console.ReadLine();

        Recipe recipe = new Recipe(name);

        Console.Write("Enter number of ingridents: ");
        int ingrdientCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter details for each ingredient: ");
        for (int i = 0; i < ingrdientCount; i++)
        {
            Console.Write($"Ingredient {i + 1} - Name: ");
            string ingrdientName = Console.ReadLine();

            Console.Write($"Quantity: ");
            double quantity = int.Parse(Console.ReadLine());

            Console.Write($"Unit of measurement: ");
            string unit = Console.ReadLine();

            Console.Write($"Calories:");
            int calories = int.Parse(Console.ReadLine());

            Console.Write($"Food Group:");
            string foodGroup = Console.ReadLine();

            recipe.AddIngredient(new Ingredient(ingrdientName, quantity, unit, calories, foodGroup));
        }

        Console.Write("Enter the number of steps: ");
        int stepCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter details for each step: ");
        for (int i =0; i<stepCount; i++)
        {
            Console.Write($"step {i + 1}:");
            string step = Console.ReadLine();
            recipe.AddStep(step);
        }

        recipes.Add(recipe);

        int totalCalories = recipe.CalculateTotalCalories();
        if (totalCalories > 300)
        {
            NotifyExceedingCalories(recipe.Name);
        }

        Console.WriteLine("Recipe added successfully");
    }

    //option 2 display all the recipes that have been stored.The recipes will store in alphabetical order
    static void DisplayAllRecipe()
    {
        if(recipes.Count == 0)
        {
            Console.WriteLine("No recipes available.");
            return;
        }
        
        //Aplhanetical code
        Console.WriteLine("\nAll recipes");
        foreach (var recipe in recipes.OrderBy(r => r.Name))
        {
            Console.WriteLine(recipe.Name);
        }
    }

    //option 3 display a single recipe from the storage
    static void DisplayRecipe()
    {
        if(recipes.Count == 0)
        {
            Console.WriteLine("No recipes available.");
            return;
        }

        Console.WriteLine("Select a recipe:");
        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {recipes[i].Name}");
        }

        Console.Write("Enter the number of the recipe to display: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= recipes.Count)
        {
            Console.WriteLine("Invalid recipe number.");
            return;
        }

        Recipe selectedRecipe = recipes[index];
        Console.WriteLine($"\nRecipe: {selectedRecipe.Name}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in selectedRecipe.Ingredients)
        {
            Console.WriteLine($"- {ingredient}");
        }

        Console.WriteLine("\nSteps:");
        for (int i = 0; i < selectedRecipe.Steps.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {selectedRecipe.Steps[i]}");
        }

        int totalCalories = selectedRecipe.CalculateTotalCalories();
        Console.WriteLine($"Total calories: {totalCalories}");
    }

    //option 3 is for scale recipe option. this allows the user to scale any recipe of the choice
    static void ScaleRecipe()
    {
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipe available");
            return;
        }

        Console.WriteLine("Select a recipe to scale:");
        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {recipes[i].Name}");
        }

        Console.Write("Enter the number of the recipe to scale: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= recipes.Count)
        {
            Console.WriteLine("Invalid recipe number.");
            return;
        }

        Console.Write("Enter scaling factor (0.5, 2, or 3): ");
        double factor = double.Parse(Console.ReadLine());

        Recipe selectedRecipe = recipes[index];
        selectedRecipe.ScaleRecipe(factor);
        Console.WriteLine($"Recipe '{selectedRecipe.Name}' scaled successfully.");
    }

    //option 4 is to notify the user if the recipe exceeds 300 calories
    static void NotifyExceedingCalories(string recipeName)
    {
        Console.WriteLine($"Warning: Total calories for recipe '{recipeName}' exceed 300!");
    }

    //option 6 is to clear all the recipes
    static void ClearAllRecipe()
    {
        recipes.Clear();
        Console.WriteLine("All recipes cleared");
    }

}
