using System;
using GoFarmFood.Web.DataAccess.Entities.Common;

namespace GoFarmFood.Web.DataAccess.Entities.ProductAggregate
{
    public class ProductItem : BaseEntity
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public virtual Product Product {get;set;}
    }
}
