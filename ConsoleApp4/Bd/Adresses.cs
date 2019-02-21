using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Bd
{
    public class Adresses
    {
        public int Id { get; set; }
        public virtual Countries Country { get; set; }
        public virtual Building Building { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }
    }
}
