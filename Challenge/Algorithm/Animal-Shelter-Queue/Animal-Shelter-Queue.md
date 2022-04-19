# Challenge Summary
<!-- Description of the challenge -->
An animal shelter holds only dogs and cats, and operates on a strictly "first in, first out " basis. People must adopt either the "oldest" (based on arrival time) of all animals at the shelter, or they can select whether they would prefer a dog or a cat (and will receive the oldest animal of that type). They cannot select which specific animal they would like. Create the data structures to maintain this system and implement operations such as enqueue ,dequeue Dog and dequeue Cat or Null .

## Whiteboard Process
<!-- Embedded whiteboard image -->
![ Animal Shelter](./img/Animal%20Shelter.jpg)
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
| Method    | Time Complexity |Space Complexity|
|-----------|-----------------|----------------|
| Enqueue  | O(1)            | O(1)           |
| Dequeue  | O(n)            | O(1)           |

## Solution
<!-- Show how to run your code, and examples of it in action -->
- Enqueue Function

```C#
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
```
- Dequeue Function

```C#
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
```

## Unit Tests

- [x] Test to Add Dog to shelter to empty queue
- [x] Test to Add Cat to shelter to empty queue
- [x] Test to Enqueue another animal

1. Test to Add Dog to shelter to empty queue

```C#
       [Fact]
        public void Test1()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Dog());
            Animal animal = animalShelter.Dequeue("dog");
            Assert.Equal("Dog", animal.Name );
        }
```

2. Test to Add Cat to shelter to empty queue

```C#
         [Fact]
        public void Test2()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Cat());
            Animal animal = animalShelter.Dequeue("cat");
            Assert.Equal("Cat", animal.Name);
        }
```

3. Test to Enqueue another animal

```C#
        [Fact]
        public void Test3()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Cat());
            animalShelter.Enqueue(new Dog());
            Animal animal = animalShelter.Dequeue("fish");
            Assert.Null(animal);
        }
```

## Code Reference

[ Animal Shelter](./Animal-Shelter/Animal-Shelter/)