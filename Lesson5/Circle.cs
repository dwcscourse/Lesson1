using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Circle : BaseShape
    {
        protected int radius; 

        public void setRadius(int r)
        {
            radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        //public double GetPerimeter(double r)
        //{
        //    return 2 * Math.PI * r;
        //}

        //public double CalculateCircleArea(double r)
        //{
        //    return Math.PI * Math.Pow(radius, 2);
        //}


    }
}
