using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using _01_Komodo_Cafe;

namespace _01_Cafe_Test
{
    [TestClass]
    public class CafeCRUDTests
    {
        public CafeUIMethodsRepo _listOfUIMethods = new CafeUIMethodsRepo(); //UIREPO
        public MealContentRepo _listOfMealMethods = new MealContentRepo(); //REPO
        public List<MealContent> _listOfMealContent = new List<MealContent>(); //POCO

        [TestMethod]
        public void C_AddEntryToList_ShouldAddAnEntryToAList()
        {
            // Arrange

            int initialCount = _listOfMealContent.Count;
            // Act

            string[] whatsInACoke = { "a 12 oz cup", "6 oz of Coke", "6oz of Ice" };
            MealContent aCoke = new MealContent(1, "A Coke", "A 12oz Coke.", whatsInACoke, 1.00);

            _listOfMealMethods.AddEntryToList(aCoke);

            int nextCount = _listOfMealContent.Count;

            // Assert
            Assert.AreNotEqual(initialCount, nextCount);
        }

        [TestMethod]
        public void R_GetEntryFromList_ShouldGetAnEntryFromAList()
        {
            // Arrange

            // Act

            // Assert

        }

        [TestMethod]
        public void D_RemoveEntryFromList_ShouldRemoveAnEntryFromAList()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}
