using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_XavierSchool
{
    public partial class FormReportStudents : Form
    {
        FormStudentList SL;
        public FormReportStudents()
        {
            InitializeComponent();
            totalStudents();
        }

        public void totalStudents()
        {
            if (File.Exists(StudentsRepository.fileName))
            {
                SL = new FormStudentList();
                richTextBoxStudentsReport.Text = SL.StudentsReport().ToString();
            }
            else
            {
                richTextBoxStudentsReport.Text = 0.ToString();
            }
        }
    }
}
