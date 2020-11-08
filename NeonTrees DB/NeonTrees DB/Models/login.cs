using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees_DB.Models
{
    public class login
    {
        [Key]
        public int loginID { get; set; }
        public int customerID { get; set; }
        public string password { get; set; }
    }
}
