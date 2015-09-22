//CIS237_Assignment_1

//Yihan Wang

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Make a Menu object of UserInterface class
            UserInterface Menu = new UserInterface();

            //make a WineFile object of CSVProecessor class
            CSVProcessor WineFile = new CSVProcessor();

            //instantiate a list object of the WineItem class
            List<WineItem> wineList = new List<WineItem>();

            // call the DisplayMainMenu method from Menu object, passing WineFile object and wineList list object
            Menu.DisplayMainMenu(WineFile, wineList);

            // call the DisplaySubMenu method from Menu object, passing wineList list object
            Menu.DisplaySubMenu(wineList);
        }
    }
}
