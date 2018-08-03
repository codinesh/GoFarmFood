using System.Collections.Generic;

namespace GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate
{
    public class Consumer : Person
    {
        public virtual ICollection<PreferredFarmer> PreferredFarmers { get; set; }
    }
}
