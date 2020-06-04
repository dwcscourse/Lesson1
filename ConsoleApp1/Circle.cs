using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Circle
    {
        //public static void Main()
        //{
        //int r = Convert.ToInt32(Console.ReadLine());
        //double area = Math.PI * r * r;
        //Console.WriteLine($"Circumference  is {area}");
        //Console.ReadLine();

        //}

        public double CalculateCircleArea(int radius) {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
