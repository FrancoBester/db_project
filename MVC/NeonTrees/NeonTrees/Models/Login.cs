﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees.Models
{
    public class Login
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string password { get; set; }

        public string userName { get; set; }
    }
}
