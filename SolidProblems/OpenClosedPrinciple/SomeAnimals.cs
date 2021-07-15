using System;

namespace SolidProblems.OpenClosedPrinciple
{
    public abstract class SomeAnimal
    {
        protected SomeAnimal(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public abstract string MakeVoice();
    }

    public class SomeDog: SomeAnimal
    {
        public SomeDog(): base("Dog") { }

        public override string MakeVoice()
        {
            return "I am dog. I am barking";
        }
    }

    public class SomeCat: SomeAnimal
    {
        public SomeCat() : base("Cat") { }
        public override string MakeVoice()
        {
            return "I am cat. I am meow";
        }
    }

    public class SomeDuck : SomeAnimal
    {
        public SomeDuck() : base("Duck") { }
        public override string MakeVoice()
        {
            return "I am duck. I am quack";
        }
    }

    public static class SomeAnimalVoice
    {
        /// <summary>
        /// Function DoAnimalVoice support OpenClosedPrinciple, because if we want
        /// add new animal we only must create new animal inherit of SomeAnimal abstract class.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public static string DoSomeAnimalVoice(SomeAnimal animal)
        {
            return animal.MakeVoice();
        }
    }
}
