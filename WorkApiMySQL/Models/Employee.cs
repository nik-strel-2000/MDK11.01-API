using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WorkApiMySQL.Models
{
    public partial class Employee
    {
        public long IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string NumberPhone { get; set; }
        public long PositionIdPosition { get; set; }

        public virtual Post PositionIdPositionNavigation { get; set; }
    }
}
