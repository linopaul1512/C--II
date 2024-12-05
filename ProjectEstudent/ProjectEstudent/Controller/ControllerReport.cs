using Microsoft.Data.SqlClient;
using ProjectEstudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEstudent.Controller
{
    internal class ControllerReport
    {

        FormReport formreport;
        List<Student> list;
        Student foundST;
        textC11Context db = new textC11Context();

        public ControllerReport(FormReport form)
        {
            formreport = form;
        }

        public void ListStudent()
        {
            db = new textC11Context();
            list = db.Student.ToList();

        }

        public void loadData()
        {
            ListStudent();
            foreach (var student  in list)
            {
                foundST = db.Student.Find(student.Id);
                formreport.dataGridViewReportx.Rows.Add(

                    student.Id,
                    student.Nameestudent,
                    student.Codefaculty    
                    );
            }
        }

        public List<Student> search_studentes_faculties(string codeFaculty)
        {
            
            var students = db.Student.Where(e => e.Codefaculty == codeFaculty).ToList();
            //students.FindAll(p => p.Id == nro);
            try
            {
                using (var db = new textC11Context()) ;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (students.Count != 0)
            {
                formreport.textBoxCodeFalcultyx.Enabled = false;
                MessageBox.Show("The faculty has been found successfully", "Faculty Found");
            }
            else
            {
                formreport.textBoxCodeFalcultyx.Enabled = true; 
                MessageBox.Show("The faculty has NOT been found successfully", "Faculty not Found");
            }
            return students;
            
        }

   
    }
}
