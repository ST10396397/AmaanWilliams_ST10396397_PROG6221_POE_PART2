using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaanWilliams_ST10396397_PROG6221_POE_PART2
{
    //ingredient classs is used to store the ingredients (Name, Quantity, Unit, Calories and its foodGroup)
    internal class Ingredient
    {
        public string Name {  get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name,double quantity, string unit, int calories, string foodgroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodgroup;

        }

        public override string ToString()
        {
                return $"{Quantity} {Unit} of {Name} ({Calories} calories)";
        }
    }
}
