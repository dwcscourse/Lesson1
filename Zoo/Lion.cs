using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Lion : AbstractAnimal, ICarnivore
    {
        public override AnimalType AnimalType
        {
            get { return AnimalType.Lion; }
        }

        public override int HabitatSize
        {
            get { return 8; }
        }

        public void EatMeat()
        {
        }

        public void Roar()
        {
        }
    }
}
