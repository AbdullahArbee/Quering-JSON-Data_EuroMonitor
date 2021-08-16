using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Json_Dataset
{
    class JSONModel
    {

        public class Rootobject
        {
            public int id { get; set; }
            public string model { get; set; }
            public string colour { get; set; }
            public string manufacturer { get; set; }
            public Saleshistory[] salesHistory { get; set; } // Also this is an array due to the nested array in the JSON data so when breaking down we use a loop
        }

        public class Saleshistory
        {
            public int year { get; set; }
            public int vehiclesSold { get; set; }
        }

    }
}
