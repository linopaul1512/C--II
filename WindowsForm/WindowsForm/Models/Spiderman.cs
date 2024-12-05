using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsForm.Models
{
    public partial class Spiderman
    {
        public string Codex { get; set; }
        public string Superheroname { get; set; }
        public string Colors { get; set; }
        public string Superpowers { get; set; }
        public string Codeuniverse { get; set; }
        public string Statusx { get; set; }

        public virtual Universe CodexNavigation { get; set; }
    }
}
