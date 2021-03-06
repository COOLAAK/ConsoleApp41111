﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Bd
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }
        public virtual Status Status { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Status Gender { get; set; }

    }
}
