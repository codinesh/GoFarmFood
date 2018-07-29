using GoFarmFood.Web.DataAccess.Entities.Common.Enums;

namespace GoFarmFood.Web.DataAccess.Entities.OrderAggregate
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }

        public ItemType ItemType { get; set; }

        public double UnitPrice { get; set; }
    }
}
