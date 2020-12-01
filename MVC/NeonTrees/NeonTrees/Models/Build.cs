using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees.Models
{
    public class Build
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int CustomerID { get; set; }

        public double Total { get; set; }

        public string OrderDetails { get; set; }

        public string ProductIDs { get; set; }
    }
}
