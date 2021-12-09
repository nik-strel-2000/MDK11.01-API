using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WorkApiMySQL.Models
{
    public partial class TRole
    {
        public TRole()
        {
            TUserRoles = new HashSet<TUserRoles>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TUserRoles> TUserRoles { get; set; }
    }
}
