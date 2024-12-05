using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectEstudent.Models
{
    public partial class Section
    {
        public Section()
        {
            StudentSection = new HashSet<StudentSection>();
        }

        public string Codesection { get; set; }
        public int? Quantitystudents { get; set; }
        public string Codeasignature { get; set; }

        public virtual Asignature CodeasignatureNavigation { get; set; }
        public virtual ICollection<StudentSection> StudentSection { get; set; }
    }
}
