using LibForMindbox.Interfaces;
using LibForMindbox.Shapes;
using System;

namespace LibForMindbox
{
    public class Circle : Shape, ICircle
    {
        private const double pi = Math.PI;
        public readonly double _radius;
        public Circle(double radius)
        {
            if (radius < 0)
                throw new Exception("The radius cannot be a negative number");

            _radius = radius;
        }

        public Circle(int diameter)
        {
            if (diameter < 0)
                throw new Exception("The diametr cannot be a negative number");

            _radius = diameter/2;
        }

        /// <summary>
        /// Рассчитать площадь круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double CalcArea()
        {
            return pi * Math.Pow(_radius, 2);
        }
    }
}
