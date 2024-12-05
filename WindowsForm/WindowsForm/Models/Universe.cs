using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsForm.Models
{
    public partial class Universe
    {
        public Universe()
        {
            Civilianvillain = new HashSet<Civilianvillain>();
        }

        public string Codex { get; set; }
        public string Namex { get; set; }
        public string Locationx { get; set; }
        public int? Quantityx { get; set; }
        public string Statex { get; set; }

        public virtual Spiderman Spiderman { get; set; }
        public virtual ICollection<Civilianvillain> Civilianvillain { get; set; }
    }
}
