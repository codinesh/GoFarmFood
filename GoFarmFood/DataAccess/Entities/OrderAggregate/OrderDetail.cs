using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.Common.Enums;
using System;

namespace GoFarmFood.Web.DataAccess.Entities.OrderAggregate
{
    public class OrderDetail : BaseEntity
    {
        public Guid OrderId { get; set; }

        public double Amount { get; set; }

        public DateTime OrderDate { get; set; }

        public double Quantity { get; set; }

        public OrderStatus Status { get; set; }

        public virtual Order Order { get; set; }
    }
}
