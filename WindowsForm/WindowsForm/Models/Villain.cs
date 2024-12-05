using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsForm.Models
{
    public partial class Villain
    {
        public Villain()
        {
            Civilianvillain = new HashSet<Civilianvillain>();
        }

        public string Codex { get; set; }
        public string Superheroname { get; set; }
        public string Origin { get; set; }
        public string Ocupation { get; set; }
        public int? Dangerousness { get; set; }
        public string Statusx { get; set; }

        public virtual ICollection<Civilianvillain> Civilianvillain { get; set; }
    }
}
