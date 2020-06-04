using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Cage
    {
        public int Size { get; }
        public bool IsEmpty
        {
            get {
                return _animals.Count == 0; }
        }

        public List<AbstractAnimal> _animals = new List<AbstractAnimal>();


        private Cage(int size)
        {
            Size = size;
        }

        public static Cage CreateCage(CageSize size)
        {
            switch (size)
            {
                case CageSize.Small:
                    return new Cage(4);
                case CageSize.Medium:
                    return new Cage(16);
                case CageSize.Big:
                    return new Cage(36);
                case CageSize.Large:
                    return new Cage(64);
                default:
                    throw new ArgumentOutOfRangeException(nameof(size), size, null);
            }
        }

        public enum CageSize
        {
            Unknown,
            Small,
            Medium,
            Big,
            Large
        }

        public bool CanAcceptAnimal(AbstractAnimal newAnimal)
        {
            int userHabitat = 0;

            foreach (var animal in _animals)
            {
                if (animal.AnimalType != newAnimal.AnimalType)
                {
                    return false;
                }
                userHabitat += animal.HabitatSize;
            }

            return userHabitat + newAnimal.HabitatSize <= Size;
        }

        public bool AddAnimal(AbstractAnimal animal)
        {
            if (CanAcceptAnimal(animal))
            {
                _animals.Add(animal);
                return true;
            }

            return false;
        }

        public void FeedAnimals()
        {
            foreach (var animal in _animals)
            {
                if (animal is IHerbivore herbivore)
                {
                    herbivore.EatGrass();
                }

                if (animal is ICarnivore carnivore)
                {
                    carnivore.EatMeat();
                }

            }
        }

    }
}
