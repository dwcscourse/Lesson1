using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public abstract class BaseShape
    {
        public string Name { get; set; }
        public Color Color { get; set; }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }

        // Overrides base method. When ToString() is called this method will be executed not the base method
        public override string ToString()
        {
            return $"Shape with name '{Name}', and perimeter {GetPerimeter()}";
        }

        // abstract method. must be overriden by child classes
        public abstract double GetPerimeter();
        public abstract double GetArea();
        
        public virtual string WhatAmI()
        {
            return "BaseShape";
        }

        // static method. can be accessed from the outside world by the class name BaseShape.GetPi()
        public static double GetPi()
        {
            return 3.14;
        }

        public virtual void Init(int a)
        {
            Console.WriteLine("Base Shape initialized");
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Perimeter: {0}", GetPerimeter());
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
