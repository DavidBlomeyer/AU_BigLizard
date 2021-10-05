using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_Komodo_Cafe
{
    // POCO - _list "blueprint"
    public class MealContent
    {
        // Variable Statement
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDesc { get; set; }
        public string[] MealIngre { get; set; }
        public double MealPrice { get; set; }

        // Zeroed Constructor
        public MealContent() { }

        // Parameterized Constructor
        public MealContent(int mealNumber, string mealName, string mealDesc, string[] mealIngre, double mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDesc = mealDesc;
            MealIngre = mealIngre;
            MealPrice = mealPrice;
        }
    }
}
