﻿using Maxim.Entities.AuditableEntity;
using Microsoft.AspNetCore.Identity;

namespace Maxim.Entities.Identity
{
    /// <summary>
    /// More info: http://www.dotnettips.info/post/2577
    /// and http://www.dotnettips.info/post/2578
    /// </summary>
    public class UserRole : IdentityUserRole<int>, IAuditableEntity
    {
        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}