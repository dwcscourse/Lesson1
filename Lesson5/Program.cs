using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle
            Rectangle r = new Rectangle(15, 8)
            {
                Color = Color.ForestGreen,
                Name = "Rectangle r"
            };

            r.Display();
            Console.WriteLine(r.WhatAmI());
            Console.WriteLine("Rectangle area is: {0}",r.GetArea());
            Console.WriteLine("Rectangle perimeter is: {0}", r.GetPerimeter());

            //Circle
            Circle c = new Circle()
            {
                Color = Color.Aquamarine,
                Name = "Circle c"
            };

            c.setRadius(Convert.ToInt32(Console.ReadLine()));
            c.Display();
            Console.WriteLine("The area of {0} is: {1}",c.Name, c.GetArea());
            Console.WriteLine("The perimeter of {0} is: {1}", c.Name, c.GetPerimeter());


            Console.ReadLine();
        }
    }
}
