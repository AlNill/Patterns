namespace Patterns
{
    public abstract class DetailDecorator: ICabinDetail
    {
        protected DetailDecorator(string name, ICabinDetail detail) : 
            base(name)
        {
            this.detail = detail;
        }

        protected ICabinDetail detail;
    }
}
