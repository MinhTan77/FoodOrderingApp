using Microsoft.AspNetCore.Identity;
using System;

namespace ProjectFinal.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
