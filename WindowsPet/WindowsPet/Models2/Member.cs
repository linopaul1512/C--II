using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsPet.Models2
{
    public partial class Member
    {
        public Member()
        {
            Gossip = new HashSet<Gossip>();
            TaskMember = new HashSet<TaskMember>();
        }

        public string Id { get; set; }
        public string Codegift { get; set; }
        public string Namemember { get; set; }
        public string Lastname { get; set; }
        public int? Phonenumber { get; set; }
        public DateTime? Datebirth { get; set; }
        public string Roomnumber { get; set; }
        public string Statusmember { get; set; }

        public virtual Gift CodegiftNavigation { get; set; }
        public virtual ICollection<Gossip> Gossip { get; set; }
        public virtual ICollection<TaskMember> TaskMember { get; set; }
    }
}
