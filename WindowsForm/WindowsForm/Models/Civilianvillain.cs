using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsForm.Models
{
    public partial class Civilianvillain
    {
        public string Codex { get; set; }
        public string Civilianname { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Codeuniverse { get; set; }
        public string Codevillain { get; set; }
        public string Statusx { get; set; }

        public virtual Villain Codeuniverse1 { get; set; }
        public virtual Universe CodeuniverseNavigation { get; set; }
    }
}
