namespace Patterns
{
    public abstract class Detail
    {
        public Detail(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name { get; set; }
        public int Cost { get; }
    }

    public class Wheel : Detail
    {
        public Wheel(string name, int cost) : base(name, cost) { }
    }

    public class Engine : Detail
    {
        public Engine(string name, int cost) : base(name, cost) { }
    }

    public class Filter : Detail
    {
        public Filter(string name, int cost) : base(name, cost) { }
    }
}
