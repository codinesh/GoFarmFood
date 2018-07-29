using GoFarmFood.Web.DataAccess.Entities.Common.Enums;
using System;

namespace GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate
{
    public class PreferredFarmer : BaseEntity
    {
        public Guid ConsumerId { get; set; }
        public Guid FarmerId { get; set; }
        public ItemType ItemType { get; set; }

        public virtual Consumer Consumer { get; set; }
    }
}
