using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_Komodo_Cafe
{
    public class MealContentRepo
    {
        // Instance the MealContent Object
        public static List<MealContent> _listOfMealContent = new List<MealContent>();

        // C
        public void AddEntryToList(MealContent content)
        {
            _listOfMealContent.Add(content);
        }

        // R
        public List<MealContent> GetEntryFromList()
        {
            return _listOfMealContent;
        }

        // U - Unused

        // D
        public bool RemoveEntryFromList(int mealNumber)
        {
            MealContent content = GetMealContentEntryByMealNumber(mealNumber);

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

        // Localized Helper Methods
        public MealContent GetMealContentEntryByMealNumber(int mealNumber)
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
