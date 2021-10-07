using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using _02_Komodo_Claims_Department;

namespace _02_Komodo_Claims_Test
{
    [TestClass]
    public class ClaimsCRUDTests
    {
        private ClaimsContentRepo _queueOfClaimMethods = new ClaimsContentRepo();

        [TestMethod]
        public void C_EnqueueEntryToQueue_ShouldEnqueueAnEntryToAQueue()
        {
            // Arrange

            Queue<ClaimsContent> _thisQueue = _02_Komodo_Claims_Department.ClaimsContentRepo._queueOfClaimsContent;

            int initialCount = _thisQueue.Count;
            Console.WriteLine(initialCount);

            // Act

            System.DateTime date1 = new System.DateTime(2021, 10, 1);
            System.DateTime date2 = new System.DateTime(2021, 10, 2);
            ClaimsContent entryOne = new ClaimsContent(1, ClaimType.Auto, "An auto accident.", 15000, date1, date2, true);
            _queueOfClaimMethods.EnqueueEntryToQueue(entryOne);

            int nextCount = _thisQueue.Count;
            Console.WriteLine(nextCount);

            // Assert

            Assert.AreNotEqual(initialCount, nextCount);
        }

        [TestMethod]
        public void R_GetEntryFromQueue()
        {
            // Arrange

            Queue<ClaimsContent> _thisQueue = _02_Komodo_Claims_Department.ClaimsContentRepo._queueOfClaimsContent;
            System.DateTime date1 = new System.DateTime(2021, 10, 1);
            System.DateTime date2 = new System.DateTime(2021, 10, 2);
            ClaimsContent entryOne = new ClaimsContent(1, ClaimType.Auto, "An auto accident.", 15000, date1, date2, true);
            _queueOfClaimMethods.EnqueueEntryToQueue(entryOne);

            // Act

            Queue<ClaimsContent> _thisNextQueue = _queueOfClaimMethods.GetEntryFromQueue();

            // Assert

            Assert.AreEqual(_thisQueue, _thisNextQueue);
        }
    }
}
