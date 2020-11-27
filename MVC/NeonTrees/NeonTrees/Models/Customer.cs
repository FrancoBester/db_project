using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees.Models
{
    public class Customer
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public char Registered { get; set; }

        public int LoginID { get; set; }
    }
}
