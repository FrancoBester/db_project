using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees_DB.Models
{
    public class Build
    {
        public int buildID { get; set; }
        public DateTime buildDate { get; set; }
        public int customerID { get; set; }
        public double total { get; set; }
    }
}
