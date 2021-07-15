using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public abstract class ServiceStationOrder
    {
        public ServiceStationOrder(string workName)
        {
            this.Name = workName;
            this.Details = new List<Detail>();
        }

        public string Name { get; set; }
        public List<Detail> Details { get; set; }
        public abstract int GetTotalCost();
    }


    public class MinskServiceStationOrder : ServiceStationOrder
    {
        public MinskServiceStationOrder() : base("Minsk Service Station Order")
        {
        }

        public override int GetTotalCost()
        {
            return this.Details.Sum(detail => detail.Cost);
        }
    }

    public class MoscowServiceStationOrder : ServiceStationOrder
    {
        public MoscowServiceStationOrder() : base("Moscow Service Station Order")
        {
        }

        public override int GetTotalCost()
        {
            return this.Details.Sum(detail => detail.Cost);
        }
    }
}
