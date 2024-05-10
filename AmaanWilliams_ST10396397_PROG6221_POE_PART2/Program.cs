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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

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
                    ClearRecipe();
                    break;
                case 6:
                    Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select another number");
                    break;
            }

        }
    }

    static void EnterNewRecipe()
    {

    }

    static void DisplayAllRecipe()
    {

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
