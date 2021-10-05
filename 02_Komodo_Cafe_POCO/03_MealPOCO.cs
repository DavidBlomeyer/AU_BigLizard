using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Komodo_Cafe_MealPR
{
    // POCO - List
    public class MealContent
    {
        // Variable Statement
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDesc { get; set; }
        public string[] MealIngre { get; set; }
        public double MealPrice { get; set; }

        // Zerod Constructor
        public MealContent() { }

        // Populated Constructor
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
