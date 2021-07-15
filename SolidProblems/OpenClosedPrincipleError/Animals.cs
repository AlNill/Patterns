using System;

namespace SolidProblems.OpenClosedPrincipleError
{
    public class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }

    public class Dog: Animal
    {
        public Dog() : base("Dog") { }

        public string Bark()
        {
            return "I am dog. I am barking";
        }
    }

    public class Cat: Animal
    {
        public Cat() : base("Cat") { }
        public string Mew()
        {
            return "I am cat. I am meow";
        }
    }

    public static class AnimalVoice
    {
        /// <summary>
        /// Function DoAnimalVoice not support OpenClosedPrinciple, because if we want
        /// add new animal we must write code in this function.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public static string DoAnimalVoice(Animal animal)
        {
            return animal.Name switch
            {
                "Dog" => ((Dog) animal).Bark(),
                "Cat" => ((Cat) animal).Mew(),
                _ => "Unknown animal"
            };
        }
    }
}
