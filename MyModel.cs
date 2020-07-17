using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCoffee
{
    public class MyModel
    {
        public string getBillID { get; set; }
        public string getCofName { get; set; }
        public string getUnit { get; set; }
        public string getCatg { get; set; }
        public string getQty { get; set; }
        public string getPrice { get; set; }
        public string getPriceTotal { get; set; }

        public double getAllPrice { get; set; }
        public int getAllQty { get; set; }
    }
}
