using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_Komodo_Cafe
{
    public class CafeProgramUI
    {
        private CafeUIMethodsRepo _listOfUIMethods = new CafeUIMethodsRepo();

        public void Run()
        {
            //_listOfUIMethods.SeedMealList();
            CafeStartMenu();
        }

        public void CafeStartMenu()
        {
            _listOfUIMethods.SeedMealList();

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("     Hello.  Welcome to the Komodo Cafe Menu App!\n" +
                                  "*******************************************************\n");
                Console.WriteLine("Blurb");
                Console.WriteLine("Select a menu option\n" +
                                  "1. See the Full Menu\n" +
                                  "2. See a Single Menu Item\n" +
                                  "3. Add a Menu Item\n" +
                                  "4. Delete a Menu Item\n" +
                                  "0. Exit");
                string inputA = Console.ReadLine();

                switch (inputA)
                {
                    case "1":
                        // See the Full Menu
                        _listOfUIMethods.SeeTheFullMenu();
                        break;
                    case "2":
                        // See a Single Menu Item
                        _listOfUIMethods.SeeASingleMenuItem();
                        break;
                    case "3":
                        // Add a Menu Item
                        _listOfUIMethods.AddAMenuItem();
                        break;
                    case "4":
                        // Delete a Menu Item
                        _listOfUIMethods.DeleteAMenuItem();
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
