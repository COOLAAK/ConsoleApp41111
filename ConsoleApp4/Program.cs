using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Model1())
            {
                Console.WriteLine(ctx.Categories.Count());
                Console.ReadKey();
            }
        }
    }
}
