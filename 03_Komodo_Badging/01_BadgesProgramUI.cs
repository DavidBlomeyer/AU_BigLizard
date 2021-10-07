using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_Komodo_Badging
{
    public class BadgesProgramUI
    {
        private BadgesUIMethodRepo _listOfUIMethods = new BadgesUIMethodRepo();

        public void Run()
        {
            //_listOfUIMethods.SeedBadgesDictionary();
            BadgesStartMenu();
        }

        public void BadgesStartMenu()
        {
            _listOfUIMethods.SeedBadgesDictionary();

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("     Hello.  Welcome to the Komodo Badging Menu App!\n" +
                                  "*********************************************************\n");
                Console.WriteLine("Home of the Badgers!");
                Console.WriteLine("Select a menu option\n" +
                                  "1. Add a Badge\n" +
                                  "2. Edit a Badge\n" +
                                  "3. Delete all Door Access from a Badge\n" +
                                  "4. List all Badges\n" +
                                  "0. Exit");
                string inputA = Console.ReadLine();

                switch (inputA)
                {
                    case "1":
                        // Add a Badge
                        _listOfUIMethods.AddABadge();
                        break;
                    case "2":
                        // Edit a Badge
                        _listOfUIMethods.EditABadge();
                        break;
                    case "3":
                        // Delete all Door access from a Badge
                        _listOfUIMethods.DeleteAllDoorAccessFromABadge();
                        break;
                    case "4":
                        // List all Badges
                        _listOfUIMethods.DisplayAllBadges();
                        break;

                    case "0":
                        // Exit
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}