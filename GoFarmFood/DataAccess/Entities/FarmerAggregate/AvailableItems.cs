using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.ProductAggregate;
using System;

namespace GoFarmFood.Web.DataAccess.Entities.FarmerAggregate
{
    public class AvailableItem : BaseEntity
    {
        public Guid FarmerId { get; set; }
        public Guid ProductItemId { get; set; }
        public int CapacityPerDay { get; set; }

        public virtual Farmer Farmer { get; set; }
        public virtual ProductItem ProductItem { get; set; }
    }
}
