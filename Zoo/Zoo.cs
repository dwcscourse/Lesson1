using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Zoo
    {
        private List<Cage> _cages = new List<Cage>();

        public void AddCage(Cage cage)
        {
            _cages.Add(cage);
        }

        public bool AddAnimal(AbstractAnimal animal)
        {
            //for (int i = 0; i < _cages.Count; i++)
            //{
            //    Cage cage = _cages[i];
            //}


            foreach (Cage cage in _cages)
            {
                if (cage.AddAnimal(animal))
                {
                    return true;
                }
            }

            return false;
        }

        public void FeedAnimals()
        {
            foreach (var cage in _cages)
            {
                cage.FeedAnimals();
            }
        }
    }
}
