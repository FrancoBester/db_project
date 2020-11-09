using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees_DB.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public double productPrice { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public int basketID { get; set; }
    }
}
