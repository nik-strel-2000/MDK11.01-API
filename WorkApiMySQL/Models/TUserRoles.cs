using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WorkApiMySQL.Models
{
    public partial class TUserRoles
    {
        public long UserId { get; set; }
        public long RolesId { get; set; }

        public virtual TRole Roles { get; set; }
        public virtual TUser User { get; set; }
    }
}
