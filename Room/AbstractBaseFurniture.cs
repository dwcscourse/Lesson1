using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room
{
    public abstract class AbstractBaseFurniture : IPaintable
    {
        public Box plot;
        public Box[] legs;

        public AbstractBaseFurniture(Box plot, Box[] legs)
        {
            this.plot = plot;
            this.legs = legs;
        }

        public virtual void Paint(Color c)
        {
            plot.Paint(c);
            for (int i = 0; i < legs.Length; i++)
            {
                legs[i].Paint (c);
            }
        }
    }
}
