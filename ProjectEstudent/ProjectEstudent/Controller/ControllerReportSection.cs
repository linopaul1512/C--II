using ProjectEstudent.Models;
using ProjectEstudent.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEstudent.Controller
{
    internal class ControllerReportSection
    {
        FormReportSection formreport;
        textC11Context db = new textC11Context();
        List<Section> list;
        Section foundSE;

        public ControllerReportSection(FormReportSection form)
        {
            formreport = form;
        }

        public void ListStudent()
        {
            db = new textC11Context();
            list = db.Section.ToList();

        }
    }
}
