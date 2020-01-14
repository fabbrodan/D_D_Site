using System;
using System.Collections.Generic;

namespace D_D_Site.Models
{
    public partial class Species
    {
        public int SpeciesId { get; set; }
        public string SpecieName { get; set; }
        public int? Sty { get; set; }
        public int? Fys { get; set; }
        public int? Smi { get; set; }
        public int? Intl { get; set; }
        public int? Psy { get; set; }
        public int? Kar { get; set; }
        public int? Sto { get; set; }
    }
}
