using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_Komodo_Cafe
{
    public class CafeUIMethodsRepo
    {
        private MealContentRepo _listOfMealMethods = new MealContentRepo();

        // Specific Verbs

        // See the Full Menu
        public void SeeTheFullMenu()
        {
            Console.Clear();
            List<MealContent> thisListOfContent = _listOfMealMethods.GetEntryFromList();

            foreach (MealContent content in thisListOfContent)
            {
                Console.WriteLine($"Meal Number: {content.MealNumber}\n" +
                                  $"Name: {content.MealName}\n" +
                                  $"Description: {content.MealDesc}\n" +
                                  $"Price: {content.MealPrice}");
            }
        }

        // See a Single Menu Item
        public void SeeASingleMenuItem()
        {
            Console.Clear();
            SeeTheFullMenu();
            Console.WriteLine("\n" +
                              "Enter the Meal Number of the Meal you'd like to see:");

            string RawMealNumber = Console.ReadLine();
            int MealNumber = int.Parse(RawMealNumber);

            MealContent content = _listOfMealMethods.GetMealContentEntryByMealNumber(MealNumber);

            if (content != null)
            {
                Console.WriteLine($"Meal Number: {content.MealNumber}\n" +
                                  $"Name: {content.MealName}\n" +
                                  $"Description: {content.MealDesc}\n" +
                                  $"Ingridients:");
                foreach (var entry in content.MealIngre)
                {
                    Console.WriteLine(entry);
                }
                Console.WriteLine($"Price: {content.MealPrice}$");
            }
            else
            {
                Console.WriteLine("No user with that ID.");
            }
        }

        // Add a Menu Item
        public void AddAMenuItem()
        {
            Console.Clear();
            MealContent newContent = new MealContent();

            // Meal Number - (assigned !)
            SeeTheFullMenu();
            Console.WriteLine("\n" +
                              "These are all existing Meals.\n" +
                              "What Meal Number would you like to assign to this Meal?\n" +
                              "[An unused one is suggested.]:");

            string RawMealNumber = Console.ReadLine();
            int MealNumber = int.Parse(RawMealNumber);
            newContent.MealNumber = MealNumber;

            // Meal Name
            Console.WriteLine("Enter Name of this Meal:");
            string enteredName = Console.ReadLine();
            newContent.MealName = enteredName;

            // Meal Description
            Console.WriteLine("Enter a description of this Meal:");
            string enteredDescription = Console.ReadLine();
            newContent.MealDesc = enteredDescription;

            // Meal Ingredients
            Console.WriteLine("Enter the ingredients of this Meal:\n" +
                              "[Format is each ingredient followed by '!']\n" +
                              "[Example: 'a 12 oz cup! 6oz of Coke! 6oz of ice']\n" +
                              "[Result: 'a 12 oz cup' '6oz of Coke' '6oz of ice']" +
                              "[If you don't want to add any, leave it blank.]\n" +
                              "[If you want to add one ingredient, list one.]");

            string input = Console.ReadLine();
            string[] pieces = input.Split('!');

            newContent.MealIngre = pieces;

            // Meal Price
            Console.WriteLine("Enter the Price of this Meal:");
            string RawMealPrice = Console.ReadLine();
            double MealPrice = double.Parse(RawMealPrice);
            newContent.MealPrice = MealPrice;

            _listOfMealMethods.AddEntryToList(newContent);
        }

        // Delete a Menu Item
        public void DeleteAMenuItem()
        {
            Console.Clear();
            SeeTheFullMenu();
            Console.WriteLine("\n" +
                              "Enter the Meal Number of the Meal you'd like to Delete:");

            string RawMealNumber = Console.ReadLine();
            int MealNumber = int.Parse(RawMealNumber);

            bool wasDeleted = _listOfMealMethods.RemoveEntryFromList(MealNumber);

            if (wasDeleted)
            {
                Console.WriteLine($"Meal Number {MealNumber} was deleted.");
            }
            else
            {
                Console.WriteLine($"Meal Number {MealNumber} is not a valid ID.");
            }
        }


        // Seed _listOfMealContent in _listOfMealMethods  (???????)
        public void SeedMealList()
        {
            string[] whatsInACoke = { "a 12 oz cup", "6 oz of Coke", "6oz of Ice" };
            string[] whatsInAPickle = { "a 8oz pickle" };

            MealContent aCoke = new MealContent(1, "A Coke", "A 12oz Coke.", whatsInACoke, 1.00);
            MealContent aPickle = new MealContent(2, "A Pickle", "A 8oz Pickle", whatsInAPickle, .50);

            _listOfMealMethods.AddEntryToList(aCoke);
            _listOfMealMethods.AddEntryToList(aPickle);
        }
    }
}