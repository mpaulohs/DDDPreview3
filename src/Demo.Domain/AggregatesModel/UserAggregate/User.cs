﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Demo.Domain.AggregatesModel.UserAggregate
{
    public class User : IdentityUser<string>
    {
        public string Name { get; set; }
        public IList<UserRole> Roles { get; set; } = new List<UserRole>();
    }
}
