using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room
{
    public class Chair : AbstractBaseFurniture
    {
        private Box back;
        public Chair (Box plot, Box[] legs, Box back) : base (plot, legs)
        {
            this.back = back;
        }

        public override void Paint(Color c)
        {
            base.Paint(c);
            back.Paint(c);
            Console.WriteLine("Paint Chair with {0}", c);
        }
    }
}
