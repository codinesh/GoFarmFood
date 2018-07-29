using System;

namespace GoFarmFood.Web.DataAccess.Entities.OrderAggregate
{
    public class PaymentInformation : BaseEntity
    {
        public Guid CustomerId {get;set;}
        public Guid CardId { get;set;}
        public string CardDetails { get;set;}
    }
}