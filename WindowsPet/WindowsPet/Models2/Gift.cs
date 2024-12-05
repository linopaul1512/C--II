using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsPet.Models2
{
    public partial class Gift
    {
        public Gift()
        {
            Member = new HashSet<Member>();
        }

        public string Codegift { get; set; }
        public string Descriptiongif { get; set; }
        public DateTime? Dategif { get; set; }
        public string Statusgif { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
