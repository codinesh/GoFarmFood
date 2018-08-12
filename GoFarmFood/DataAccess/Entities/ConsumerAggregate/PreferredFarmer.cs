using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.Common.Enums;
using System;

namespace GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate
{
    public class PreferredFarmer : BaseEntity
    {
        public Guid ConsumerId { get; set; }
        public Guid FarmerId { get; set; }
        public Category ItemType { get; set; }

        public virtual Rider Rider { get; set; }
    }
}
