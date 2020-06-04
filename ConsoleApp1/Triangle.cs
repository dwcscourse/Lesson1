using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Triangle
    {
        //private int side1Length;
        //private int side2Length;
        //private int side3Length;

        //public Triangle(int side1, int side2, int side3) {
        //    side1Length = side1;
        //    side2Length = side2;
        //    side3Length = side3;
        //}

        //public double CalculateTriangleArea()
        //{
        //    double p = CalculateSemiPerimeter(side1Length, side2Length, side3Length);
        //    double area = Math.Sqrt(p * (p - side1Length) * (p - side2Length) * (p - side3Length));

        //    return area;
        //}

        public double CalculateTriangleArea(int a, int b, int c)
        {
            double p = CalculateSemiPerimeter(a, b, c);
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        public double CalculateSemiPerimeter(int a, int b, int c)
            {
                double p;
                return p = (a + b + c) / 2;
            }
    }
}
