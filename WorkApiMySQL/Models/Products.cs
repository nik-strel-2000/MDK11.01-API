using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WorkApiMySQL.Models
{
    public partial class Products
    {
        public long IdProduct { get; set; }
        public string Name { get; set; }
        public long TypeProductIdTypeProduct { get; set; }
        public string TypeMaterial { get; set; }

        public virtual TypeProduct TypeProductIdTypeProductNavigation { get; set; }
    }
}
