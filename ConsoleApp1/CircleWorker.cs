using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class CircleWorker
    {
        public void start() {
            Console.WriteLine("Give me circle radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            Circle circle1 = new Circle();
            double circleArea = circle1.CalculateCircleArea(radius);
            Console.WriteLine($"Circle area is: {circleArea}");
          
        }
    }
}
