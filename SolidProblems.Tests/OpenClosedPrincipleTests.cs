using NUnit.Framework;
using SolidProblems.OpenClosedPrinciple;
using SolidProblems.OpenClosedPrincipleError;

namespace SolidProblems.Tests
{
    public class Tests
    {

        [Test]
        public void Test1DemonstrateOpenClosedPrinciple()
        {
            Animal dog = new Dog();
            Assert.AreEqual("I am dog. I am barking", AnimalVoice.DoAnimalVoice(dog));
        }

        [Test]
        public void Test2DemonstrateOpenClosedPrinciple()
        {
            SomeAnimal dog = new SomeDog();
            Assert.AreEqual("I am dog. I am barking", SomeAnimalVoice.DoSomeAnimalVoice(dog));
        }
    }
}