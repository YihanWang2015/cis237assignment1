using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        // variables
        private string wineId;
        private string wineName;
        private string wineAmount;


        // no argument constructor
        public WineItem()
        {

        }

        // constructor that can pass 3 arguments
        public WineItem(string _wineId, string _wineName, string _wineAmount)
        {
            this.wineId = _wineId;
            this.wineName = _wineName;
            this.wineAmount = _wineAmount;
        }

        // properties
        public string WINEID
        {
            get { return this.wineId; }
            set { this.wineId = value; }
        }

        public string WINEName
        {
            get { return this.wineName; }
            set { this.wineName = value; }
        }

        public string WINEAmount
        {
            get { return this.wineAmount; }
            set { this.wineAmount = value; }
        }


        // override ToString() method for the WineItem class
        public override string ToString()
        {
            return this.wineId + "\t" + this.wineName + "\t\t\t" + this.wineAmount;
        }

    }
}
