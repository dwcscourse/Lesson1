using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Elephant : AbstractAnimal, IHerbivore
    {
        public override int HabitatSize
        {
            get { return 16; }
        }

        public override AnimalType AnimalType
        {
            get { return AnimalType.Elephant;  }
        }

        public void EatGrass()
        {
        }

        public void DrinkFromTheNose()
        {
        }
    }
}
