using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FuturartTheaterInc.Models
{
    public partial class TheaterPlays
    {
        public string Code { get; set; }
        public string Nametp { get; set; }
        public string Authorsname { get; set; }
        public DateTime Releasedate { get; set; }
        public string Statex { get; set; }
        public string City { get; set; }
        public DateTime Lastmodification { get; set; }
        public string Status { get; set; }
    }
}
