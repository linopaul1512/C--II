using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsPet.Models2
{
    public partial class Gossip
    {
        public string Codegossip { get; set; }
        public string Descriptiongossip { get; set; }
        public string Idmember { get; set; }
        public string Statusgossip { get; set; }

        public virtual Member IdmemberNavigation { get; set; }
    }
}
