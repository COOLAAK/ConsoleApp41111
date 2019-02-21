using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Bd
{
     public class RealProduct
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public virtual AbstrProduct AbstrProduct { get; set; }
        public virtual Producer Producer { get; set; }

        public DateTime ProductionDave { get; set; }
        public DateTime ExpiresDate { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public int Quantity { get; set; }

    }
}
