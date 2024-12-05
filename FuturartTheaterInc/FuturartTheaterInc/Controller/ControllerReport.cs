using FuturartTheaterInc.Models;
using FuturartTheaterInc.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturartTheaterInc.Controller
{
    internal class ControllerReport
    {
        FormReport formreport;
        List<TheaterPlays> list;
        TheaterPlays foundTP;
        textC10Context db = new textC10Context();
        TheaterPlays teacherplays;

        public ControllerReport(FormReport form)
        {
            formreport = form;
        }

        public void listTeacherPlays()
        {
            db = new textC10Context();
            list = db.TheaterPlays.ToList();

        }

        public void loadData()
        {
            listTeacherPlays();
            foreach (var teacherplays in list)
            {
                foundTP = db.TheaterPlays.Find(teacherplays.Code);
               
                formreport.dataGridViewReportx.Rows.Add(

                    teacherplays.Code,
                    teacherplays.Nametp,
                    teacherplays.Authorsname,
                    teacherplays.Statex,
                    teacherplays.City
                    );
            }
        }


   








    }






}
