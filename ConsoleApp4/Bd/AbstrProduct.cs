﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Bd
{
     public class AbstrProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public virtual Categories Category { get; set; }
    }

}