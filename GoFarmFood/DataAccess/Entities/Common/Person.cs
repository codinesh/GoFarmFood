﻿using System;

namespace GoFarmFood.Web.DataAccess.Entities.Common
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid AddressId { get; set; }

        public Address Address { get; set; }

        public int Proximity { get; set; }
    }
}
