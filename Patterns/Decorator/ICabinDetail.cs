namespace Patterns.Decorator;

public abstract class ICabinDetail
{
    public ICabinDetail(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public abstract int GetCost();
}
