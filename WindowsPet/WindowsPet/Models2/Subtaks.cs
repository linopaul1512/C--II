using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsPet.Models2
{
    public partial class Subtaks
    {
        public Subtaks()
        {
            Task = new HashSet<Task>();
        }

        public string Codesubtask { get; set; }
        public string Descriptionsubtaks { get; set; }
        public string Statussubtaks { get; set; }

        public virtual ICollection<Task> Task { get; set; }
    }
}
