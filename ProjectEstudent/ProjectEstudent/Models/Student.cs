using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectEstudent.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentSection = new HashSet<StudentSection>();
        }

        public string Id { get; set; }
        public string Nameestudent { get; set; }
        public DateTime Datebirth { get; set; }
        public string Direction { get; set; }
        public string Phonenumber { get; set; }
        public string Codefaculty { get; set; }
        public string Statusestudent { get; set; }

        public virtual Faculty CodefacultyNavigation { get; set; }
        public virtual ICollection<StudentSection> StudentSection { get; set; }
    }
}
