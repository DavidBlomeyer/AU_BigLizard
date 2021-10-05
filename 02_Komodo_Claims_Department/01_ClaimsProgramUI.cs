using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Komodo_Claims_Department
{
    public class ClaimsProgramUI
    {
        private ClaimsUIMethodsRepo _listOfUIMethods = new ClaimsUIMethodsRepo();

        public void Run()
        {
            //_listOfUIMethods.SeedClaimsQueue();
            ClaimsStartMenu();
        }

        public void ClaimsStartMenu()
        {
            _listOfUIMethods.SeedClaimsQueue();

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("     Hello.  Welcome to the Komodo Claims Department Claims Queue App!\n" +
                                  "*******************************************************\n");
                Console.WriteLine("Blurb");
                Console.WriteLine("Select a menu option\n" +
                                  "1. See All Claims\n" +
                                  "2. Take care of the next Claim\n" +
                                  "3. Enter a new Claim\n" +
                                  "0. Exit");
                string inputA = Console.ReadLine();

                switch (inputA)
                {
                    case "1":
                        // See All Claims
                        _listOfUIMethods.SeeAllClaims();
                        break;
                    case "2":
                        // Take care of next Claim
                        _listOfUIMethods.TakeCareOfNextClaim();
                        break;
                    case "3":
                        // Enter a new Claim
                        _listOfUIMethods.EnterANewClaim();
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

