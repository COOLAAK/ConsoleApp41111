using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Bd
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Adresses Adresses { get; set; }
        public virtual ICollection<RealProduct> RealProducts { get; set; }
    }
}
