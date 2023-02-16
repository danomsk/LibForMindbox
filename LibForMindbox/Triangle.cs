using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibForMindbox
{
    public class Triangle : IShape
    {
        public readonly double side1;
        public readonly double side2;
        public readonly double side3;
        private double[] arr_for_rect = new double[2];

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double CalcArea()
        {
            if (IsRectangular())
            {
                return (arr_for_rect[0] * arr_for_rect[1]) / 2;
            }
            else
            {
                double p = (side1 + side2 + side3) / 2;
                double s = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                if (double.IsNaN(s))
                    throw new Exception("There is no triangle with such sides");

                return s;
            }
        }

        private bool IsRectangular()
        {
            if (SquareHypot(side1, side2) == side3)
            {
                arr_for_rect[0] = side1;
                arr_for_rect[1] = side2;
                return true;
            }
            else if (SquareHypot(side2, side3) == side1)
            {
                arr_for_rect[0] = side2;
                arr_for_rect[1] = side3;
                return true;
            }
            else if (SquareHypot(side1, side3) == side2)
            {
                arr_for_rect[0] = side1;
                arr_for_rect[1] = side3;
                return true;
            }
            else
                return false;
        }

        private double SquareHypot(double side1, double side2)
        {
            return Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
        }
    }
}
