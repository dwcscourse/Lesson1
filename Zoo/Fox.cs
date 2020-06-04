using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Fox : AbstractAnimal, IHerbivore, ICarnivore
    {
        public override AnimalType AnimalType
        {
            get { return AnimalType.Fox;  }
        }

        public override int HabitatSize
        {
            get { return 2;  }
        }

        public void EatGrass()
        {
        }

        public void EatMeat()
        {
        }

        public void StealTheCheese()
        {
        }
    }
    
}
