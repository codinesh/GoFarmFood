using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate;
using System;
using System.Collections.Generic;

namespace GoFarmFood.Web.DataAccess.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public Guid ConsumerId { get; set; }

        public Guid FarmerId { get; set; }

        public Guid ProductItemId { get; set; }

        public double TotalAmount { get; set; }

        public double Quantity { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public PaymentInformation PaymentInformation { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
