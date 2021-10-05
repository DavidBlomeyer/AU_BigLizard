using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace _02_Komodo_Claims_Department
{
    public class ClaimsUIMethodsRepo
    {
        private ClaimsContentRepo _queueOfClaimMethods = new ClaimsContentRepo();

        // Specific Verbs

        // See All Claims
        public void SeeAllClaims()
        {
            Console.Clear();
            Console.WriteLine($"ClaimID     Type     Description     Amount     Date Of Incident     Date of Claim     Is Valid?");

            Queue<ClaimsContent> thisQueueofContent = _queueOfClaimMethods.GetEntryFromQueue();
            foreach (ClaimsContent content in thisQueueofContent)
            {
                Console.WriteLine($"{content.ClaimID} {content.TypeOfClaim} {content.ClaimDescription} {content.ClaimAmount} {content.DateOfIncident} {content.DateOfClaim} {content.ClaimIsValid}");
            }
        }

        // Take care of next Claim
        public void TakeCareOfNextClaim()
        {
            Console.Clear();
            // Dequeue
            ClaimsContent content = _queueOfClaimMethods.PeekClaimsContentEntry();

            Console.WriteLine($"Claim ID: {content.ClaimID}\n" +
                              $"Type: {content.TypeOfClaim}\n" +
                              $"Description: {content.ClaimDescription}\n" +
                              $"Amount: {content.ClaimAmount}\n" +
                              $"Date of Incident: {content.DateOfIncident}\n" +
                              $"Date of Claim {content.DateOfClaim}\n" +
                              $"Is Valid?: {content.ClaimIsValid}\n");
            Console.WriteLine("Do you want to deal with this claim now(y/n)?");

            string response = Console.ReadLine().ToLower();

            if (response == "y")
            {
                _queueOfClaimMethods.DequeueClaimsContentEntry();
            }
            else if (response == "n")
            {
                // Return to ClaimsStartMenu
            }
            else
            {
                Console.WriteLine("That is not 'y' or 'n'.");
            }
        }

        // Enter a new Claim
        public void EnterANewClaim()
        {
            Console.Clear();
            ClaimsContent newContent = new ClaimsContent();

            // ClaimID
            SeeAllClaims();
            Console.WriteLine("\n" +
                              "These are all existing Claims.\n" +
                              "What Meal Number would you like to assign to this Claim?\n" +
                              "[An unused one is suggested.]:");

            string rawClaimIDResponse = Console.ReadLine();
            int claimIDResponse = int.Parse(rawClaimIDResponse);
            newContent.ClaimID = claimIDResponse;

            // ClaimType
            Console.WriteLine("What type of claim is this (1 = Auto, 2 = Home, 3 = Theft)?");
            string rawClaimTypeResponse = Console.ReadLine();
            int claimTypeResponse = int.Parse(rawClaimTypeResponse);
            newContent.TypeOfClaim = (ClaimType) claimTypeResponse;

            // ClaimDescription
            Console.WriteLine("Enter a description of the claim.:");
            string claimDescriptionResponse = Console.ReadLine();
            newContent.ClaimDescription = claimDescriptionResponse; 

            // ClaimAmount
            Console.WriteLine("What is the Amount ($) of the Claim?:");
            string rawClaimAmountResponse = Console.ReadLine();
            double claimAmountResponse = double.Parse(rawClaimAmountResponse);
            newContent.ClaimAmount = claimAmountResponse;

            // DateOfIncident
            Console.WriteLine("When did the incident of the Claim occur?\n" +
                              "[Example for Oct 1, 2021]");
            Console.WriteLine("Year (2021 example)?");
            string rawIncidentYear = Console.ReadLine();
            int incidentYear = int.Parse(rawIncidentYear);

            Console.WriteLine("Month (10 example)?");
            string rawIncidentMonth = Console.ReadLine();
            int incidentMonth = int.Parse(rawIncidentMonth);

            Console.WriteLine("Day (1 example)?");
            string rawIncidentDay = Console.ReadLine();
            int incidentDay = int.Parse(rawIncidentDay);

            System.DateTime incidentDateTime = new System.DateTime(incidentYear, incidentMonth, incidentDay);
            newContent.DateOfIncident = incidentDateTime;

            // DateOfClaim
            Console.WriteLine("When did the Claim occur?\n" +
                              "[Example for Oct 8, 2021]");
            string rawClaimDateOfClaim = Console.ReadLine();
            Console.WriteLine("Year (2021 example)?");
            string rawClaimYear = Console.ReadLine();
            int claimYear = int.Parse(rawClaimYear);

            Console.WriteLine("Month (10 example)?");
            string rawClaimMonth = Console.ReadLine();
            int claimMonth = int.Parse(rawClaimMonth);

            Console.WriteLine("Day (1 example)?");
            string rawClaimDay = Console.ReadLine();
            int claimDay = int.Parse(rawClaimDay);

            System.DateTime claimDateTime = new System.DateTime(claimYear, claimMonth, claimDay);
            newContent.DateOfClaim = claimDateTime;

            // ClaimIsValid
            TimeSpan difference = incidentDateTime - claimDateTime;
            TimeSpan allowedSpan = new TimeSpan(30, 0, 0, 0);

            if (difference <= allowedSpan)
            {
                bool thisClaimIsValid = true;
                newContent.ClaimIsValid = thisClaimIsValid;
            }
            else
            {
                bool thisClaimIsValid = false;
                newContent.ClaimIsValid = thisClaimIsValid;
            }

            _queueOfClaimMethods.EnqueueEntryToQueue(newContent);

            Console.WriteLine("New Claim added to Queue.");
        }


        // Seed _queueOfClaimsContent in _queueOfClaimsMethods
        public void SeedClaimsQueue()
        {
            System.DateTime date1 = new System.DateTime(2021, 10, 1);
            System.DateTime date2 = new System.DateTime(2021, 10, 2);
            System.DateTime date3 = new System.DateTime(2021, 10, 3);
            System.DateTime date4 = new System.DateTime(2021, 10, 4);

            ClaimsContent entryOne = new ClaimsContent(1, ClaimType.Auto, "An auto accident.", 15000, date1, date2, true);
            ClaimsContent entryTwo = new ClaimsContent(2, ClaimType.Home, "A home fire.", 20000, date3, date4, false);

            _queueOfClaimMethods.EnqueueEntryToQueue(entryOne);
            _queueOfClaimMethods.EnqueueEntryToQueue(entryTwo);
        }
    }

    
}