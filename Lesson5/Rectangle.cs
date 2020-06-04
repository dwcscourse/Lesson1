using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Rectangle : BaseShape
    {
        public static int Count = 5;

        public int Width { get; }
        public int Height { get; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public static int GetPerimeter(int w, int h)
        {
            return 2 * (w + h);
        }

        public override double GetPerimeter()
        {
            return GetPerimeter(Width, Height);
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override string WhatAmI()
        {
            return "Rectangle";
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Height: {0}", Height);
            Console.WriteLine("Width: {0}", Width);
            
        }

    }
}
