using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees_DB.Models
{
    public class RawProduct
    {
        public int rawProductID { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public double inventoryValue { get; set; }
        public string url { get; set; }
        public string partType { get; set; }
    }
}
