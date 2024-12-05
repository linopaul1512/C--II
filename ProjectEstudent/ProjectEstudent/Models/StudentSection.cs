using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectEstudent.Models
{
    public partial class StudentSection
    {
        public string CodeSs { get; set; }
        public string Codesection { get; set; }
        public string Id { get; set; }

        public virtual Section CodesectionNavigation { get; set; }
        public virtual Student IdNavigation { get; set; }
    }
}
