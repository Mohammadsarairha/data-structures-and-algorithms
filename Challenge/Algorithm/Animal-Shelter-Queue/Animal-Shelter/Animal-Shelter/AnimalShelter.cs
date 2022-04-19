using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Shelter
{
    public class AnimalShelter
    {
        public Queue<Cat> Cats = new();
        public Queue<Dog> Dogs = new();

        public void Enqueue(Animal animal)
        {
            if (animal is Cat)
            {
                Cats.Enqueue(animal as Cat);
            }
            else if (animal is Dog)
            {
                Dogs.Enqueue(animal as Dog);
            }
        }

        public Animal Dequeue(string pref)
        {
            if (pref == "cat")
            {
                if (Cats.Count != 0)
                {
                    Animal cat = Cats.Dequeue();
                    return cat;
                }
            }
            else if (pref == "dog")
            {
                if (Dogs.Count != 0)
                {
                    Animal dog = Dogs.Dequeue();
                    return dog;
                }
            }
                return null;
        }
    }
}
