using System;

namespace GoFarmFood.DataAccess.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
