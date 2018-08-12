using GoFarmFood.Web.DataAccess.Entities.Common;
using GoFarmFood.Web.DataAccess.Entities.OrderAggregate;

namespace GoFarmFood.Web.DataAccess.Entities.FarmerAggregate
{
    public class Farmer : Person
    {
        public virtual Order OrderAggregate {get;set;}
    }
}
