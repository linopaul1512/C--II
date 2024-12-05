using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectEstudent.Models
{
    public partial class AsignatureFaculty
    {
        public string CodeAf { get; set; }
        public string Codeasignature { get; set; }
        public string Codefaculty { get; set; }

        public virtual Asignature CodeasignatureNavigation { get; set; }
        public virtual Faculty CodefacultyNavigation { get; set; }
    }
}
