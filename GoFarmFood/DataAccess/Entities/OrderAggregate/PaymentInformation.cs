using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.Common.Enums;
using System;

namespace GoFarmFood.Web.DataAccess.Entities.OrderAggregate
{
    public class PaymentInformation : BaseEntity
    {
        public Guid CustomerId {get;set;}
        public Guid CardId { get;set;}
        public string CardDetails { get;set;}
        public PaymentStatus Status{ get;set; }
    }
}