using GoFarmFood.Web.DataAccess.Entities.Common;
using System;

namespace GoFarmFood.Web.DataAccess.Entities.ProductAggregate
{
    public class ProductPrice : BaseEntity
    {
        public Guid AddressId { get; set; }

        public Guid ProductItemId { get; set; }

        public double PricePerUnit { get; set; }

        public virtual ProductItem ProductItem { get; set; }
    }
}
