using System;
using System.Collections.Generic;

// Interfata pentru animale
interface IAnimal
{
    string Name { get; }
    string MakeSound();
}

// Clase pentru diferite tipuri de animale
class Dog : IAnimal
{
    public string Name => "Dog";
    public string MakeSound() => "Bark";
}

class Cow : IAnimal
{
    public string Name => "Cow";
    public string MakeSound() => "Moo";
}

class Cat : IAnimal
{
    public string Name => "Cat";
    public string MakeSound() => "Meow";
}

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
            Console.WriteLine($"{animal.Name} makes sound: {animal.MakeSound()}"); 
        }
    } 
}
