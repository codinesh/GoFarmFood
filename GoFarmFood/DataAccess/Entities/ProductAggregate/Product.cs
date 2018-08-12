using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.Common.Enums;
using System.Collections.Generic;

namespace GoFarmFood.Web.DataAccess.Entities.ProductAggregate
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public Category Category { get; set; }

        public ProductStatus Status { get; set; }

        public virtual ICollection<ProductItem> ProductItems { get; set; }
    }
}