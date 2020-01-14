using System;
using System.Collections.Generic;

namespace D_D_Site.Models
{
    public partial class Roles
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int? Sty { get; set; }
        public int? Fys { get; set; }
        public int? Smi { get; set; }
        public int? Intl { get; set; }
        public int? Psy { get; set; }
        public int? Kar { get; set; }
    }
}
