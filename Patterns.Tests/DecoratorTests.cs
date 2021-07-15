using NUnit.Framework;

namespace Patterns.Tests
{
    public class Tests
    {
        [Test]
        public void Test()
        {
            ICabinDetail detail = new Sitting();
            detail = new LeatherDetail(detail);
            detail = new AlcantaraDetail(detail);
            detail = new ClothDetail(detail);

            Assert.AreEqual(1060, detail.GetCost());
        }
    }
}