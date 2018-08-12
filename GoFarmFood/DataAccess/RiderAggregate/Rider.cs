using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.OrderAggregate;
using System.Collections.Generic;

namespace GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate
{
    public class Rider : Person
    {
        public ICollection<Order> Orders { get; set; }
    }
}
