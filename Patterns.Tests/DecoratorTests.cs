using NUnit.Framework;

namespace Patterns.Tests
{
    public class Tests
    {
        [Test]
        public void TestCreateCombineSitting()
        {
            // Create sitting detail. Start cost - 30
            ICabinDetail detail = new Sitting();
            // Add leather insert to detail. Cost increase on 300
            detail = new LeatherDetail(detail);
            // Add alcantara insert to detail. Cost increase on 700
            detail = new AlcantaraDetail(detail);
            // Add cloth insert to detail. Cost increase on 30
            detail = new ClothDetail(detail);

            Assert.AreEqual(1060, detail.GetCost());
            // As result we have sitting with leather, alcantara and cloth inserts
            Assert.AreEqual("Sitting Add leather insert Add alcantara insert Add cloth insert",
            detail.Name);
        }

        [Test]
        public void TestCreateLeatherRudder()
        {
            // Create rudder detail. Start cost - 10
            ICabinDetail detail = new Rudder();
            // Add leather insert to detail. Cost increase on 300
            detail = new LeatherDetail(detail);
            Assert.AreEqual(310, detail.GetCost());
            // As result we have rudder with leather
            Assert.AreEqual("Rudder Add leather insert", detail.Name);
        }

        [Test]
        public void TestCreatePanelWithLeatherAndPlastic()
        {
            // Create panel detail. Start cost - 40
            ICabinDetail detail = new Panel();
            // Add leather insert to detail. Cost increase on 300
            detail = new LeatherDetail(detail);
            // Add plastic insert to detail. Cost increase on 10
            detail = new PlasticDetail(detail);
            Assert.AreEqual(350, detail.GetCost());
            // As result we have panel with leather and plastic
            Assert.AreEqual("Panel Add leather insert Add plastic insert",
                detail.Name);
        }
    }
}