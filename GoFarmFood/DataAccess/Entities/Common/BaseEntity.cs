using System;
using System.ComponentModel.DataAnnotations;

namespace GoFarmFood.Web.DataAccess.Entities.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
