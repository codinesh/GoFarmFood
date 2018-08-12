namespace GoFarmFood.Web.DataAccess.Entities.Common
{
    public class Address : BaseEntity
    {
        public int ZipCode { get; set; }

        public string CompleteAddress { get; set; }

        public string Name { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Landmark { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }
    }
}