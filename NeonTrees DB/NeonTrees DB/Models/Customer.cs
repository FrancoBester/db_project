using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees_DB.Models
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }

        public string customerName { get; set; }

        public string customerSurname { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public bool registered { get; set; }
        public int loginID { get; set; }
    }
}
