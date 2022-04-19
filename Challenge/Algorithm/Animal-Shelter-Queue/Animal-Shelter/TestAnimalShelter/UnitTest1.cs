using System;
using Xunit;
using Animal_Shelter;

namespace TestAnimalShelter
{
    public class UnitTest1
    {
        //Test to Add Dog to shelter
        [Fact]
        public void Test1()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Dog());
            Animal animal = animalShelter.Dequeue("dog");
            Assert.Equal("Dog", animal.Name );
        }

        //Test to Add Cat to shelter
        [Fact]
        public void Test2()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Cat());
            Animal animal = animalShelter.Dequeue("cat");
            Assert.Equal("Cat", animal.Name);
        }

        //Test to Enqueue another animal
        [Fact]
        public void Test3()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Cat());
            animalShelter.Enqueue(new Dog());
            Animal animal = animalShelter.Dequeue("fish");
            Assert.Null(animal);
        }
    }
}
