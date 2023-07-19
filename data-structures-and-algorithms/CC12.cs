using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public Animal(string s, string n)
        {
            Species = s;
            Name = n;
        }
    }
    public class AnimalShelter
    {
        public Queue<Animal> dogs;
        public Queue<Animal> cats;

        public AnimalShelter()
        {
            dogs = new Queue<Animal>();
            cats = new Queue<Animal>();
        }
        public void Enqueue(Animal a)
        {
            if(a.Species.ToLower()=="cat")
            cats.Enqueue(a);

            else if(a.Species.ToLower()=="dog")
                dogs.Enqueue(a);
            else
            {
                throw new ArgumentException("Invalid species");
            }
        }
        public Animal Dequeue(string pref)
        {
            if (pref == "cat")
            {
                return cats.Dequeue();
            }
            else if (pref == "dog")
            {
                return dogs.Dequeue();
            }

            return null;
        }
    }
}
