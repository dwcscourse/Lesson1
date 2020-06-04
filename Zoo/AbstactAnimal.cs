using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class AbstractAnimal
    {
        public abstract int HabitatSize { get; }
        public abstract AnimalType AnimalType { get; }
    }
}
