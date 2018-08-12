using GoFarmFood.Web.DataAccess.Entities.Common;
using System;

namespace GoFarmFood.Web.DataAccess.Entities.ProductAggregate
{
    public class ProductItemAvailability : BaseEntity
    {
        public Guid ProductItemId { get; set; }

        public int Quantity { get; set; }

        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        public double Price { get; set; }

        public virtual ProductItem ProductItem { get; set; }
    }
}