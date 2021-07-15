namespace Patterns
{
    public class Sitting : ICabinDetail
    {
        public Sitting() : base("Sitting") { }
        public override int GetCost()
        {
            return 30;
        }
    }

    public class Panel : ICabinDetail
    {
        public Panel() : base("Panel") { }
        public override int GetCost()
        {
            return 40;
        }
    }

    public class Rudder : ICabinDetail
    {
        public Rudder() : base("Rudder") { }
        public override int GetCost()
        {
            return 10;
        }
    }
}
