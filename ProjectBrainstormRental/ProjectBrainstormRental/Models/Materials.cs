using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectBrainstormRental.Models2
{
    public partial class Materials
    {
        public Materials()
        {
            MaterialsAppointment = new HashSet<MaterialsAppointment>();
        }

        public string Codematerials { get; set; }
        public string Descriptionservice { get; set; }
        public double Puccharseprice { get; set; }
        public double Sale { get; set; }
        public string Statusmaterials { get; set; }

        public virtual ICollection<MaterialsAppointment> MaterialsAppointment { get; set; }
    }
}
