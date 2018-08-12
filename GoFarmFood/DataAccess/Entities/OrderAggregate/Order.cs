using GoFarmFood.Web.DataAccess.Entities.Common;
using System;

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

        public PaymentInformation PaymentInfor { get; set; }
    }
}
