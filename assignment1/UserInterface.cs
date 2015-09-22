using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {

        // no argument constructor
        public UserInterface()
        {

        }

        // Display the main menu for the user. 
        public void DisplayMainMenu(CSVProcessor WineFile, List<WineItem> wineList)
        {
            bool quitMainBoolean = false;

            // do while loop keeps showing the menu
            do
            {
                Console.WriteLine("Select an option: \n \n 1. Load the csv file of wine list.  2. Exit program.");
                string optionSelection = Console.ReadLine();

                if (optionSelection == "1")
                {
                    quitMainBoolean = true;
                    WineFile.ReadCSV(wineList);
                }
                else if (optionSelection == "2")
                {
                    Environment.Exit(0);
                }

            } while (quitMainBoolean != true);

        }

        // display the sub  menu for the user
        public void DisplaySubMenu(List<WineItem> wineList)
        {
            bool quitSubBoolean = false;

            WineItemCollection Collection = new WineItemCollection();

            // do while loop keeps showing the sub menu for the user until user hits exit
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Enter the number corresponding which action you wish to perform: ");
                Console.WriteLine("\n");
                Console.WriteLine("1. Print the entire csv file of WineList.");
                Console.WriteLine("2. Search wine by ID number.");
                Console.WriteLine("3. Add a new wine to the list.");
                Console.WriteLine("4. Exit the program.");

                string inputString = Console.ReadLine();

                // "if" statement is used in case user doesn't input anything and press enter.
                if (inputString.Trim() != string.Empty)
                {
                    //try catch is for invalid user input in case they don't input integer.
                    try
                    {
                        int inputInt = int.Parse(inputString);

                        switch (inputInt)
                        {
                            case 1:
                                for (int i = 0; i < wineList.Count; i++)
                                {
                                    Console.WriteLine(wineList[i]);
                                }
                                break;
                            case 2:
                                Console.WriteLine("\n");
                                Collection.SearchById(wineList);
                                break;
                            case 3:
                                Collection.AddWine(wineList);
                                break;
                            case 4:
                                // jump out of the loop
                                quitSubBoolean = true;
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid Input");
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine("Invalid data. Please enter an integer.");
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("No data entered");
                }

            } while (quitSubBoolean != true);
        }

    }
}
