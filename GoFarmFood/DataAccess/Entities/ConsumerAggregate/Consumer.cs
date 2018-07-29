using System.Collections.Generic;

namespace GoFarmFood.Web.DataAccess.Entities.ConsumerAggregate
{
    public class Consumer : BaseEntity
    {
        public virtual ICollection<PreferredFarmer> PreferredFarmers { get; set; }
    }
}
