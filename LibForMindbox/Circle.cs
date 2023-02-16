using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibForMindbox
{
    public class Circle : IShape
    {
        private const double pi = Math.PI;
        public readonly double radius;
        public Circle(double radius)
        {
            if (radius < 0)
                throw new Exception("The radius cannot be a negative number");

            this.radius = radius;
        }
        public double CalcArea()
        {
            return pi * Math.Pow(radius, 2);
        }
    }
}
