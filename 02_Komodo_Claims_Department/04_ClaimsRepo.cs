﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Komodo_Claims_Department
{
    public class ClaimsContentRepo 
    {
        // Instance the ClaimsContent Object
        private Queue<ClaimsContent> _queueOfClaimsContent = new Queue<ClaimsContent>();

        // Verbs

        // C
        public void EnqueueEntryToQueue(ClaimsContent content)
        {
            _queueOfClaimsContent.Enqueue(content);
        }

        // R
        public Queue<ClaimsContent> GetEntryFromQueue()
        {
            return _queueOfClaimsContent;
        }

        // U - Unused
        public bool UpdateEntryInQueue(int originalClaimID, ClaimsContent newContent)
        {
            return true;
        }

        // D - Unused
        public bool RemoveEntryFromQueue(int claimID)
        {
            return true;
        }

        // Localized Helper Methods
        public ClaimsContent GetClaimsContentEntryByClaimID(int claimsID)
        {
            foreach (ClaimsContent content in _queueOfClaimsContent)
            {
                if (content.ClaimID == claimsID)
                {
                    return content;
                }
            }

            return null; // not found
        }

        public ClaimsContent DequeueClaimsContentEntry()
        {
            if (_queueOfClaimsContent != null)
            {
                return _queueOfClaimsContent.Dequeue();
            }
            else
            {
                Console.WriteLine("The queue is empty.\n" +
                                  "Press any key to continue.");
                Console.ReadKey();
                return null;
            }

        }

        public ClaimsContent PeekClaimsContentEntry()
        {
            if (_queueOfClaimsContent != null)
            {
                return _queueOfClaimsContent.Peek();
            }
            else
            {
                Console.WriteLine("The queue is empty.\n" +
                                  "Press any key to continue.");
                Console.ReadKey();
                return null;
            }
        }
    }
}