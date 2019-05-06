using System;
using Microsoft.AspNetCore.Identity;

namespace SaveBridge.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public Guid? CityId { get; set; }

        public string Address { get; set; }

        public City City { get; set; }
    }
}