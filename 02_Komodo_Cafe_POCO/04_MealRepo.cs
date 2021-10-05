using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Komodo_Cafe_MealPR
{
    public class MealContentRepo
    {
        private List<MealContent> _listOfMealContent = new List<MealContent>(); /// ???

        // C
        public void AddMealContent(MealContent content)
        {
            _listOfMealContent.Add(content);
        }

        // R
        public List<MealContent> SeeFullMealContent()
        {
            return _listOfMealContent;
        }

        public void SeeASingleMealContent()
        {
            Console.Clear();
            SeeFullMealContent();
            Console.WriteLine("\n" +
                              "Enter the Menu Number of the Meal you'd like to see:");
            string mealNumber = Console.ReadLine();
            int mealNumberParsed = int.Parse(mealNumber);

            MealContent mealContent = GetMealContentByMealNumber(mealNumberParsed);

            if (mealContent != null)
            {
                Console.WriteLine($"Meal Number: {mealContent.MealNumber}\n" +
                                  $"Name: {mealContent.MealName}\n" +
                                  $"Desc: {mealContent.MealDesc}\n" +
                                  $"Ingri: {mealContent.MealIngre}\n" +
                                  $"Price:: {mealContent.MealPrice}");
            }
            else
            {
                Console.WriteLine("No Meal with that Meal Number.");
            }
        }

        // U - not needed

        // D

        public bool DeleteMealContent(int mealNumber)
        {
            MealContent content = GetMealContentByMealNumber(mealNumber);

            if (content == null)
            {
                return false;
            }

            int intialCount = _listOfMealContent.Count;
            _listOfMealContent.Remove(content);

            if (intialCount > _listOfMealContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper Methods

        public MealContent GetMealContentByMealNumber(int mealNumber)
        {
            foreach (MealContent content in _listOfMealContent)
            {
                if (content.MealNumber == mealNumber)
                {
                    return content;
                }
            }

            return null; // not found
        }
    }
}
