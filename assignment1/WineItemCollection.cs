using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class WineItemCollection
    {
        private string userInputString;

        // no argument constructor
        public WineItemCollection()
        {

        }

        public void SearchById(List<WineItem> wineList)
        {
            WineItem result = null;

            do
            {
                Console.WriteLine("Search Records:");
                Console.Write("Enter Id to search for:");

                userInputString = Console.ReadLine();

                result = wineList.Find(x => x.WINEID == userInputString);

                if (result == null)
                {
                    Console.WriteLine("Invalid Value");
                }

            } while (result == null);

            Console.WriteLine("ID        Name                                    Amount");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(result.ToString());
        }

        public void AddWine(List<WineItem> wineList)
        {
            string addWineId;
            string addWineName;
            string addWineAmount;

            Console.WriteLine("Enter the new wine ID:");
            addWineId = Console.ReadLine();

            Console.WriteLine("Enter the new wine name:");
            addWineName = Console.ReadLine();

            Console.WriteLine("Enter the new wine amount:");
            addWineAmount = Console.ReadLine();

            string path = @"..\..\..\datafiles\WineList.csv";

            wineList.Add(new WineItem(addWineId, addWineName, addWineAmount));

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("{0}, {1}, {2}", addWineId, addWineName, addWineAmount);
            }

            Console.WriteLine("\n Wine has been added:");
            Console.WriteLine("ID   Name  Amount");
            Console.WriteLine("------------------");
            Console.WriteLine("{0},   {1},   {2}", addWineId, addWineName, addWineAmount);
        }

    }
}
