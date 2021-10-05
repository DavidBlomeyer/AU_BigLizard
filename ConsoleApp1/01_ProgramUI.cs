using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _01_Komodo_Cafe;
using _02_Komodo_Claims_Department;
using _03_Komodo_Badging;


namespace _00_Komodo_Gold_Console
{
    class KomodoGoldProgramUI
    {
        CafeProgramUI _cafe = new CafeProgramUI();
        ClaimsProgramUI _claims = new ClaimsProgramUI();
        BadgesProgramUI _badges = new BadgesProgramUI();

        public void Run()
        {
            KomodoGoldStartMenu();
        }

        private void KomodoGoldStartMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("     Hello.  Welcome to the Komodo Gold Console App!\n" +
                                  "*********************************************************\n");
                Console.WriteLine("     This is set up as a test of the 'Apps' below which are set up as stand-alone programs.\n" +
                                  "     Inside these apps if you use the exit option in closes the console rather then returning to this menu.\n" +
                                  "     As of now, the 'Mains' in each App are enabled, so if you want to run them separately you can go in and \n" +
                                  "     'not' mains/switch around Startup Projects.\n" +
                                  "");
                Console.WriteLine("Select a menu option\n" +
                                  "1. Cafe App\n" +
                                  "2. Claims App\n" +
                                  "3. Badges App\n" +
                                  "0. Exit");
                string inputA = Console.ReadLine();

                switch (inputA)
                {
                    case "1":
                        // Cafe App
                        _cafe.CafeStartMenu();
                        break;
                    case "2":
                        // Claims App
                        _claims.ClaimsStartMenu();
                        break;
                    case "3":
                        // Badges App
                        _badges.BadgesStartMenu();
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