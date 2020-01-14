using System;
using System.Collections.Generic;

namespace D_D_Site.Models
{
    public partial class Characters
    {
        public int UserId { get; set; }
        public string CharacterName { get; set; }
        public int SpeciesId { get; set; }
        public int RoleId { get; set; }
    }
}
