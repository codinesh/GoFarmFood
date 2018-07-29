using GoFarmFood.DataAccess.Entities.Common;

namespace GoFarmFood.DataAccess.Entities.FarmerAggregate
{
    public class Farmer : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }
    }
}
