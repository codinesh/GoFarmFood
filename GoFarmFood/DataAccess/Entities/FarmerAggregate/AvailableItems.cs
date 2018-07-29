using System;

namespace GoFarmFood.Web.DataAccess.Entities.FarmerAggregate
{
    public class AvailableItem : BaseEntity
    {
        public Guid FarmerId { get; set; }
        public Guid ItemId { get; set; }
        public int CapacityPerDay { get; set; }
    }
}
