using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test12
    {
        [Fact]
        public void testAnimalShelterEnqueueDog()
        {
            AnimalShelter test = new AnimalShelter();
            Animal dog = new Animal("dog", "Booby");

            test.Enqueue(dog);

            Assert.Single(test.dogs);
            Assert.Empty(test.cats);
        }

        [Fact]
        public void testAnimalShelterEnqueueCat()
        {
            AnimalShelter test = new AnimalShelter();
            Animal cat = new Animal("cat", "kitty");

            test.Enqueue(cat);

            Assert.Single(test.cats);
            Assert.Empty(test.dogs);
        }
        [Fact]
        public void testAnimalShelterEnqueueIncorrectSpecies()
        {
           AnimalShelter test = new AnimalShelter();
            Animal hamster = new Animal("hamster", "Fluffy");

            Assert.Throws<ArgumentException>(() => test.Enqueue(hamster));
        }

        [Fact]
        public void testAnimalShelterDequeuePrefIsCat()
        {
            AnimalShelter test = new AnimalShelter();
            Animal cat = new Animal("cat", "kitty");
            test.Enqueue(cat);

            Animal dequeuedAnimal = test.Dequeue("cat");

            Assert.Equal(cat, dequeuedAnimal);
            Assert.Empty(test.cats);
        }

        [Fact]
        public void testAnimalShelterDequeuePrefIsDog()
        {
            AnimalShelter test = new AnimalShelter();
            Animal dog = new Animal("Dog", "Booby");
            test.Enqueue(dog);

            Animal dequeuedAnimal = test.Dequeue("dog");

            Assert.Equal(dog, dequeuedAnimal);
            Assert.Empty(test.dogs);
        }

        [Fact]
        public void testAnimalShelterDequeuePrefIsElse()
        {
            AnimalShelter test = new AnimalShelter();

            Animal dequeuedAnimal = test.Dequeue("hamster");

            Assert.Null(dequeuedAnimal);
        }
    }
}
