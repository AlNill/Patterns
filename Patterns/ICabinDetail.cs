namespace Patterns
{
    public abstract class ICabinDetail
    {
        public ICabinDetail(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public abstract int GetCost();
    }
}
