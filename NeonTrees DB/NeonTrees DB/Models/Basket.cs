using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees_DB.Models
{
    public class Basket
    {
        public int basketID { get; set; }
        public int productID { get; set; }
        public double productPrice { get; set; }
        public int quantity { get; set; }
    }
}
