using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibForMindbox;

namespace TETS
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Triangle(10, 10, 2);
            var c = new Circle(-12);

            IShape[] test = { t, c };
            
            foreach(var z in test)
            {
                Console.WriteLine(z.CalcArea());
            }
        }
    }
}
