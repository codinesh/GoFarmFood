using System;

namespace GoFarmFood.Web.DataAccess.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public Guid ConsumerId { get; set; }
        public Guid FarmerId { get; set; }
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
        public PaymentInformation PaymentInfor { get; set; }
    }
}
