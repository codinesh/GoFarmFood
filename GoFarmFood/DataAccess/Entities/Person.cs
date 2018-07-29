using GoFarmFood.Web.DataAccess.Entities.Common;

namespace GoFarmFood.Web.DataAccess.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }
    }
}
