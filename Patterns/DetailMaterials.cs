namespace Patterns
{
    public class LeatherDetail: DetailDecorator
    {
        public LeatherDetail(ICabinDetail detail) : 
            base(detail.Name + "Add leather insert", detail) { }

        public override int GetCost()
        {
            return detail.GetCost() + 300;
        }
    }

    public class ClothDetail : DetailDecorator
    {
        public ClothDetail(ICabinDetail detail) :
            base(detail.Name + "Add cloth insert", detail)
        { }

        public override int GetCost()
        {
            return detail.GetCost() + 30;
        }
    }

    public class AlcantaraDetail : DetailDecorator
    {
        public AlcantaraDetail(ICabinDetail detail) :
            base(detail.Name + "Add alcantara insert", detail)
        { }

        public override int GetCost()
        {
            return detail.GetCost() + 700;
        }
    }

    public class PlasticDetail : DetailDecorator
    {
        public PlasticDetail(ICabinDetail detail) :
            base(detail.Name + "Add plastic insert", detail)
        { }

        public override int GetCost()
        {
            return detail.GetCost() + 10;
        }
    }
}
