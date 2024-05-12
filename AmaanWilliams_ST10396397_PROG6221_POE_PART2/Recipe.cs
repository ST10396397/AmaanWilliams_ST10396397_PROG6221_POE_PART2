using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaanWilliams_ST10396397_PROG6221_POE_PART2
{
    internal class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List <string> Steps { get; set; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void AddStep(string step) 
        {
            Steps.Add(step);
        }

        public int CalculateTotalCalories()
        {
            int totalCalories = Ingredients.Sum(ingredient => ingredient.Calories);
            return totalCalories;
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ClearRecipe()
        {
            Ingredients.Clear();
            Steps.Clear();
        }


    }
}
