using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsPet.Models2
{
    public partial class Task
    {
        public Task()
        {
            TaskMember = new HashSet<TaskMember>();
        }

        public string Codetask { get; set; }
        public string Descriptiontaks { get; set; }
        public string Ubication { get; set; }
        public string Codesubtask { get; set; }
        public string Statustaks { get; set; }

        public virtual Subtaks CodesubtaskNavigation { get; set; }
        public virtual ICollection<TaskMember> TaskMember { get; set; }
    }
}
