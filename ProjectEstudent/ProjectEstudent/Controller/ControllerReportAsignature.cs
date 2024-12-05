using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProjectEstudent.Models;
using ProjectEstudent.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEstudent.Controller
{
    internal class ControllerReportAsignature
    {

        FormReportAsignatures formreport;
        List<Asignature> list;
        Asignature foundAS;
        textC11Context db = new textC11Context();
        Student student;
        string namestudent;
        public ControllerReportAsignature(FormReportAsignatures form)
        {
            formreport = form;
        }

        public void ListAsignature()
        {
            db = new textC11Context();
            list = db.Asignature.ToList();

        }

        public void loadData()
        {
            ListAsignature();
            foreach (var asignature in list)
            {
                foundAS = db.Asignature.Find(asignature.Codeasignature);
                formreport.dataGridViewAsignaturex.Rows.Add(

                    
                    asignature.Codeasignature,
                    asignature.Nameasignature
                    );
            }
        }

       public List<Asignature> search_students_asignatures(string  codeStudent)
        {

            StudentSection estudianteSeccion = new StudentSection();
            

            string sqlreport = "Select subject.code,subject.name,student.id " +
                    "                                     From Asignature,Student,Student_Section,Section" +
                    "                                     where Student.Id = Student_Section.Id  " +
                    "                                     and Student_Section.codesection = Section.codesection " +
                    "                                     and Section.codeasignature = Asignature.codeasignature";
            List<Asignature> consulta = db.Asignature.FromSqlRaw(sqlreport).ToList();

            
       
            if (sqlreport != null)
            {
                formreport.textBoxCodeAsignaturex.Enabled = false;
                MessageBox.Show("The Asignature has been found successfully", "Asignature Found");
            }
            else
            {
                formreport.textBoxCodeAsignaturex.Enabled = true;
                MessageBox.Show("The Asignature has NOT been found successfully", "Asignature not Found");
            }
            return consulta;

        }

       








    }


}
