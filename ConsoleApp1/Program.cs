using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Program
    {
        public static void Main()
        {
            //double c = CalculateHypotenuse(3, 4);

            //double f = CalculateHypotenuse(6, 8);

            //double i = CalculateHypotenuse(30, 40);

            //Console.WriteLine($"Results: {c}; {f} and {i}");
            //Console.ReadLine();

            //HW1 Triangle area
            Console.WriteLine("Give me triangle sides");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Triangle triangle1 = new Triangle();
            double area = triangle1.CalculateTriangleArea(a, b, c);
            Console.WriteLine($"Triangle area  is {area}");

            
            //HW2 Circle area
            CircleWorker circleWorker = new CircleWorker();
            circleWorker.start();

            Console.ReadLine();

        }

        public static double CalculateHypotenuse(int a, int b)
        {
            a = a * a;
            b = b * b;

            return Math.Sqrt(a + b);
        }
    }

}
