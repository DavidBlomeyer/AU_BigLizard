using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using _01_Komodo_Cafe;

namespace _01_Cafe_Test
{
    [TestClass]
    public class CafeCRUDTests
    {
        public MealContentRepo _listOfMealMethods = new MealContentRepo();

        [TestMethod]
        public void C_AddEntryToList_ShouldAddAnEntryToAList()
        {
            // Arrange

            List<MealContent> _thisList = _01_Komodo_Cafe.MealContentRepo._listOfMealContent;

            int initialCount = _thisList.Count;
            Console.WriteLine(initialCount);

            // Act

            string[] whatsInACoke = { "a 12 oz cup", "6 oz of Coke", "6oz of Ice" };
            MealContent aCoke = new MealContent(1, "A Coke", "A 12oz Coke.", whatsInACoke, 1.00);
            _listOfMealMethods.AddEntryToList(aCoke);

            int nextCount = _thisList.Count;
            Console.WriteLine(nextCount);

            // Assert

            Assert.AreNotEqual(initialCount, nextCount);
        }

        [TestMethod]
        public void R_GetEntryFromList_ShouldGetAnEntryFromAList()
        {
            // Arrange

            List<MealContent> _thisList = _01_Komodo_Cafe.MealContentRepo._listOfMealContent;
            string[] whatsInACoke = { "a 12 oz cup", "6 oz of Coke", "6oz of Ice" };
            MealContent aCoke = new MealContent(1, "A Coke", "A 12oz Coke.", whatsInACoke, 1.00);
            _listOfMealMethods.AddEntryToList(aCoke);

            // Act

            List<MealContent> _thisNextList = _listOfMealMethods.GetEntryFromList();

            // Assert

            Assert.AreEqual(_thisList, _thisNextList);
        }

        [TestMethod]
        public void D_RemoveEntryFromList_ShouldRemoveAnEntryFromAList()
        {
            // Arrange

            List<MealContent> _thisList = _01_Komodo_Cafe.MealContentRepo._listOfMealContent;
            string[] whatsInACoke = { "a 12 oz cup", "6 oz of Coke", "6oz of Ice" };
            MealContent aCoke = new MealContent(1, "A Coke", "A 12oz Coke.", whatsInACoke, 1.00);
            _listOfMealMethods.AddEntryToList(aCoke);

            int initialCount = _thisList.Count;
            Console.WriteLine(initialCount);

            // Act

            _listOfMealMethods.RemoveEntryFromList(1);

            int nextCount = _thisList.Count;
            Console.WriteLine(nextCount);

            // Assert

            Assert.AreNotEqual(initialCount, nextCount);
        }
    }
}
