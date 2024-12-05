using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectEstudent.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            AsignatureFaculty = new HashSet<AsignatureFaculty>();
            Student = new HashSet<Student>();
        }

        public string Codefaculty { get; set; }
        public string Namefaculty { get; set; }
        public string Professionalprofile { get; set; }
        public string Title { get; set; }
        public string Statusfaculty { get; set; }

        public virtual ICollection<AsignatureFaculty> AsignatureFaculty { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
