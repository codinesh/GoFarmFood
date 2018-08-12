using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.Common.Enums;

namespace GoFarmFood.Web.DataAccess.Entities.OrderAggregate
{
    public class ProductItem : BaseEntity
    {
        public string Name { get; set; }

        public Category Category { get; set; }

        public double UnitPrice { get; set; }
    }
}
