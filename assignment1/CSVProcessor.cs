using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        public CSVProcessor()
        {

        }

        public void ReadCSV(List<WineItem> wineList)
        {
            try
            {
                // load the csv file
                var reader = new StreamReader(File.OpenRead(@"..\..\..\datafiles\WineList.csv"));

                string[] values = new string[3];

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    //place the value into the list object
                    values = line.Split(',');

                    wineList.Add(new WineItem(values[0], values[1], values[2]));
                }
                //close the file 
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The csv file of WineList is not found"); ;
            }

        }
    }
}
