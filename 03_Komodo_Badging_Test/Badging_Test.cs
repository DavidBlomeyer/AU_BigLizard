using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using _03_Komodo_Badging;

namespace _03_Komodo_Badging_Test
{
    [TestClass]
    public class BadgingCRUDTests
    {
        private BadgesContentRepo _dictionaryOfBadgesMethods = new BadgesContentRepo();

        [TestMethod]
        public void C_AddEntryToDictionary_ShouldAddAnEntryToDictionary()
        {
            // Arrange

            IDictionary<int, BadgesContent> _thisDictionary = _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent;

            int initialCount = _thisDictionary.Count;
            Console.WriteLine(initialCount);

            // Act

            BadgesContent aBadge = new BadgesContent();
            aBadge.BadgeID = 1;
            List<string> aDoor = new List<string>();
            aDoor.Add("A1");
            aDoor.Add("A2");
            aBadge.DoorAccess = aDoor;

            _dictionaryOfBadgesMethods.AddEntryToDictionary(aBadge);

            int nextCount = _thisDictionary.Count;
            Console.WriteLine(nextCount);

            // Assert

            Assert.AreNotEqual(initialCount, nextCount);

            _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent.Clear();
        }

        [TestMethod]
        public void R_GetEntryFromDictionary_ShouldGetAllEntriesFromDictionary()
        {
            // Arrange

            IDictionary<int, BadgesContent> _thisDictionary = _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent;
            BadgesContent aBadge = new BadgesContent();
            aBadge.BadgeID = 1;
            List<string> aDoor = new List<string>();
            aDoor.Add("A1");
            aDoor.Add("A2");
            aBadge.DoorAccess = aDoor;
            _dictionaryOfBadgesMethods.AddEntryToDictionary(aBadge);

            // Act

            IDictionary<int, BadgesContent> _thisNextDictionary = _dictionaryOfBadgesMethods.GetEntryFromDictionary();

            // Assert

            Assert.AreEqual(_thisDictionary, _thisNextDictionary);

            _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent.Clear();
        }

        [TestMethod]
        public void U_UpdateDoorListOnBadge_ShouldUpdateDoorListingOnAnExistingBadge()
        {
            // Arrange

            IDictionary<int, BadgesContent> _thisDictionary = _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent;
            BadgesContent aBadge = new BadgesContent();
            aBadge.BadgeID = 1;
            List<string> aDoor = new List<string>();
            aDoor.Add("A1");
            aDoor.Add("A2");
            aBadge.DoorAccess = aDoor;
            _dictionaryOfBadgesMethods.AddEntryToDictionary(aBadge);

            var initialState = _dictionaryOfBadgesMethods.GetBadgesContentEntryByBadgeID(1);
            int initialCount = initialState.DoorAccess.Count;
            Console.WriteLine(initialCount);

            // Act

            _dictionaryOfBadgesMethods.UpdateDoorListOnBadge(1, "A3");

            var nextState = _dictionaryOfBadgesMethods.GetBadgesContentEntryByBadgeID(1);
            int nextCount = initialState.DoorAccess.Count;
            Console.WriteLine(nextCount);

            // Assert

            Assert.AreNotEqual(initialCount, nextCount);

            _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent.Clear();
        }

        [TestMethod]
        public void D_RemoveAllEntriesFromDictionaryByBadgeID_ShouldRemoveAllEntriesFromADictionaryUsingABadgeID()
        {
            // Arrange

            IDictionary<int, BadgesContent> _thisDictionary = _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent;
            BadgesContent aBadge = new BadgesContent();
            aBadge.BadgeID = 1;
            List<string> aDoor = new List<string>();
            aDoor.Add("A1");
            aDoor.Add("A2");
            aBadge.DoorAccess = aDoor;
            _dictionaryOfBadgesMethods.AddEntryToDictionary(aBadge);

            int initialCount = _thisDictionary.Count;
            Console.WriteLine(initialCount);

            // Act

            _dictionaryOfBadgesMethods.RemoveAllEntriesFromDictionaryByBadgeID(1);

            int nextCount = _thisDictionary.Count;
            Console.WriteLine(nextCount);

            // Assert

            Assert.AreNotEqual(initialCount, nextCount);

            _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent.Clear();
        }

        [TestMethod]
        public void D_RemoveEntryFromDictionaryByBadgeIDAndDoorAccess_ShouldRemoveADoorAccessFromAKVPFromADictionaryUsingABadgeIDAndADoorAccess()
        {
            // Arrange

            IDictionary<int, BadgesContent> _thisDictionary = _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent;
            BadgesContent aBadge = new BadgesContent();
            aBadge.BadgeID = 1;
            List<string> aDoor = new List<string>();
            aDoor.Add("A1");
            aDoor.Add("A2");
            aBadge.DoorAccess = aDoor;
            _dictionaryOfBadgesMethods.AddEntryToDictionary(aBadge);

            var initialState = _dictionaryOfBadgesMethods.GetBadgesContentEntryByBadgeID(1);
            int initialCount = initialState.DoorAccess.Count;
            Console.WriteLine(initialCount);

            // Act

            _dictionaryOfBadgesMethods.RemoveEntryFromDictionaryByBadgeIDAndDoorAccess(1, "A1");

            var nextState = _dictionaryOfBadgesMethods.GetBadgesContentEntryByBadgeID(1);
            int nextCount = nextState.DoorAccess.Count;
            Console.WriteLine(nextCount);

            // Assert

            Assert.AreNotEqual(initialCount, nextCount);

            _03_Komodo_Badging.BadgesContentRepo._dictionaryOfBadgesContent.Clear();
        }
    }
}
