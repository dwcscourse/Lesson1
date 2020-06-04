using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Rabbit : AbstractAnimal, IHerbivore
    {
        public override AnimalType AnimalType
        {
            get { return AnimalType.Rabbit; }
        }

        public override int HabitatSize
        {
            get { return 1;  }
        }

        public void EatGrass()
        { 
        }

        public void DoZigZag()
        {
        }
    }
}
