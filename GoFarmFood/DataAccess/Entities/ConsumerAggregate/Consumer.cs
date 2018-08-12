using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.OrderAggregate;
using System.Collections.Generic;

namespace GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate
{
    public class Consumer : Person
    {
        public virtual ICollection<PreferredFarmer> PreferredFarmers { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
