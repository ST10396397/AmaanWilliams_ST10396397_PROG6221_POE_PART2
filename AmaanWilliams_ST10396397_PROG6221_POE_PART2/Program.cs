// See https://aka.ms/new-console-template for more information
using AmaanWilliams_ST10396397_PROG6221_POE_PART2;

class program
{
    static List <Recipe> recipes = new List <Recipe> ();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Enter a new recipe ");
            Console.WriteLine("2. Display all recipes");
            Console.WriteLine("3. Display a recipe");
            Console.WriteLine("4. Scale a reccipe");
            Console.WriteLine("5. Clear all recipe");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
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
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select another number");
                    break;
            }

        }
    }

    static void EnterNewRecipe()
    {
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

    static void DisplayAllRecipe()
    {
        if()
    }

    static void DisplayRecipe()
    {

    }

    static void ScaleRecipe()
    {

    }

    static void NotifyExceedingCalories(string recipeName)
    {

    }

    static void ClearAllRecipe()
    {

    }

}
