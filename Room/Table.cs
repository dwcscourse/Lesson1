using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room
{
    class Table : AbstractBaseFurniture
    {
        public Fabric cover;
        public Table(Box plot, Box[] legs, Fabric cover) : base(plot, legs)
        {
            this.cover = cover;
        }
    }
}
