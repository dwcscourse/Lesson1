using System;
using System.Collections.Generic;
using System.Drawing;

namespace Room
{
    public class Painter
    {
        public void Paint(Color paint, IPaintable p)
        {
            p.Paint(paint);             
            Console.WriteLine("Painter is used");
        }
    }
}
