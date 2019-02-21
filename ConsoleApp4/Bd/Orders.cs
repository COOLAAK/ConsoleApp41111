using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Bd
{
     public class Orders
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual RealProduct RealProduct { get; set; }
        public virtual Adresses DeliverAdreses { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
    }
}
