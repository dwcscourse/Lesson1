using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Circle
    {
        private double radius; 
        private double x; 
        private double y;
        private Color color; 

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public Circle(double r) : this(r,0,0, Color.Gray)
        {
        }

        //public Circle(double r)
        //{
        //    this.radius = r;
        //    x = 0;
        //    y = 0;
        //    Color = Color.Gray;
        //}

        public Circle(double r, double x, double y) : this(r, x, y, Color.Gray)
        {
        }

        //public Circle(double r, double x, double y)
        //{
        //    this.radius = r;
        //    this.x = x;
        //    this.y = y;
        //    Color = Color.Gray;
        //}

        public Circle(double r, double x, double y, Color color)
        {
            this.radius = r;
            this.x = x;
            this.y = y;
            this.Color = color;
        }

        public double GetPerimeter (double r)
        {
            return  2 * Math.PI * r;
        }

        public double CalculateCircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

    }
}
