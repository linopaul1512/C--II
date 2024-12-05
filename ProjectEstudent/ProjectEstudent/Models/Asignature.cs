using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectEstudent.Models
{
    public partial class Asignature
    {
        public Asignature()
        {
            AsignatureFaculty = new HashSet<AsignatureFaculty>();
            Section = new HashSet<Section>();
        }

        public string Codeasignature { get; set; }
        public string Nameasignature { get; set; }
        public int Creditunits { get; set; }
        public int Theoryhours { get; set; }
        public int Hourspractice { get; set; }
        public int? Semester { get; set; }
        public string Statusasignature { get; set; }

        public virtual ICollection<AsignatureFaculty> AsignatureFaculty { get; set; }
        public virtual ICollection<Section> Section { get; set; }
    }
}
