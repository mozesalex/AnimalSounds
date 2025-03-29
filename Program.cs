using System;
using System.Collections.Generic;
using AnimalSounds.AnimalModels;
using AnimalSounds;
class Program
{
    static void Main(string[] args)
    {
        List<IAnimal> animals = new List<IAnimal>
        {
            new Dog(),
            new Cat(),
            new Cow()
        };

        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.GetType().Name} makes sound: {animal.MakeSound()}");
        }
    }
}
