using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsPet.Models2
{
    public partial class TaskMember
    {
        public string Codetaskmember { get; set; }
        public string Codetask { get; set; }
        public string Id { get; set; }
        public DateTime? Datetask { get; set; }
        public string Statustk { get; set; }

        public virtual Task CodetaskNavigation { get; set; }
        public virtual Member IdNavigation { get; set; }
    }
}
