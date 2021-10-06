using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _03_Komodo_Badging
{
    public class BadgesUIMethodRepo
    {
        private BadgesContentRepo _dictionaryOfBadgesMethods = new BadgesContentRepo();

        // Specific Verbs

        // Add a Badge
        public void AddABadge()
        {
            Console.Clear();

            Console.WriteLine("What is the number on the badge:");
            string rawBadgeToCreate = Console.ReadLine();
            int badgeToCreate = int.Parse(rawBadgeToCreate);

            Console.WriteLine("List a door that it needs access to:");
            string doorToAdd = Console.ReadLine();

            BadgesContent newContent = new BadgesContent();
            newContent.BadgeID = badgeToCreate;
            newContent.DoorAccess.Add(doorToAdd);

            _dictionaryOfBadgesMethods.AddEntryToDictionary(newContent);

            Console.WriteLine("Any other doors(y/n)?");
            string yesNo = Console.ReadLine().ToLower();

            if (yesNo == "y")
            {
                AddAnotherDoorToBadge(badgeToCreate);
            }
            else { }
        }

        public void AddAnotherDoorToBadge(int badgeToCreate)
        {
            Console.WriteLine("List a door that it needs access to:");
            string doorToAdd = Console.ReadLine();

            _dictionaryOfBadgesMethods.UpdateDoorListOnBadge(badgeToCreate, doorToAdd);

            Console.WriteLine("Any other doors(y/n)?");
            string yesNo = Console.ReadLine().ToLower();

            if (yesNo == "y")
            {
                AddAnotherDoorToBadge(badgeToCreate);
            }
            else { }
        }

        // Edit a Badge
        public void EditABadge()
        {
            Console.Clear();

            Console.WriteLine("What is the badge number to update?");
            string rawBadgeToUpdate = Console.ReadLine();
            int badgeToUpdate = int.Parse(rawBadgeToUpdate);

            Console.WriteLine("What would you like to do?\n" +
                              "1. Remove a Door\n" +
                              "2. Add a Door\n" +
                              "3. Exit");
            string inputB = Console.ReadLine();

            switch (inputB)
            {
                case "1":
                    Console.WriteLine("What Door would you like to remove?");
                    string doorToRemove = Console.ReadLine();
                    _dictionaryOfBadgesMethods.RemoveEntryFromDictionaryByBadgeIDAndDoorAccess
                        (badgeToUpdate, doorToRemove);
                    break;

                case "2":
                    Console.WriteLine("What Door would you like to add?");
                    string doorToAdd = Console.ReadLine();

                    _dictionaryOfBadgesMethods.UpdateDoorListOnBadge(badgeToUpdate, doorToAdd);
                    break;

                case "3":
                    Console.WriteLine("Returning to Menu");
                    break;
            }
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        
        // Delete all Door access from a Badge
        public void DeleteAllDoorAccessFromABadge()
        {
            Console.Clear();
            Console.WriteLine("What is the number of Badge you would like to remove all Door Access from?");
            string rawBadgeToPurge = Console.ReadLine();
            int badgeToPurge = int.Parse(rawBadgeToPurge);

            _dictionaryOfBadgesMethods.RemoveAllEntriesFromDictionaryByBadgeID(badgeToPurge);

            Console.WriteLine($"Badge {badgeToPurge} has been purged");
        }

        // List all Badges
        public void DisplayAllBadges()
        {
            Console.Clear();
            IDictionary<int, BadgesContent> thisDictionaryOfContent = _dictionaryOfBadgesMethods.GetEntryFromDictionary();

            foreach (var contentBadgeID in thisDictionaryOfContent)
            {
                Console.WriteLine($"BadgeID: {contentBadgeID.Key}");
                for (int i = 0; i < contentBadgeID.Value.DoorAccess.Count; i++)
                {
                    Console.WriteLine($"{contentBadgeID.Value.DoorAccess[i]}");
                }
            }
        }

        // Seed _dictionaryOfBadgesContent in _dictionaryOfBadgesMethods
        public void SeedBadgesDictionary()
        {
            BadgesContent aBadge = new BadgesContent();
            aBadge.BadgeID = 1;
            List<string> aDoor = new List<string>();
            aDoor.Add("A1");
            aDoor.Add("A2");
            aBadge.DoorAccess = aDoor;

            _dictionaryOfBadgesMethods.AddEntryToDictionary(aBadge);
        }
    }
}