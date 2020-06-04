using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Circle circle1 = new Circle(10, 0, 0, Color.Aquamarine);
            double Area1 = circle1.CalculateCircleArea(5);
        }
    }
}
