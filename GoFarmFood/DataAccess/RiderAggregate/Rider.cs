using GoFarmFood.Web.DataAccess.Entities.Common;
using System;
using System.Collections.Generic;

namespace GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate
{
    public class Rider : Person
    {
        public Guid RiderId { get; set; }
        public Guid OrderId { get; set; }
    }
}
