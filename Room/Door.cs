using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room
{
    class Door
    {
        public Box wing;
        public Box[] frames = new Box[3];

        public void Paint(Color c)
        {
            wing.Paint(c);
            for (int i = 0; i < frames.Length; i++)
            {
                frames[i].Paint(c);
            }
        }
    }
}
