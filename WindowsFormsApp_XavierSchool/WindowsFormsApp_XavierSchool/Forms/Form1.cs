using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_XavierSchool.Forms;

namespace WindowsFormsApp_XavierSchool
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonStudentManager_Click(object sender, EventArgs e)
        {
            FormStudentManagers SM = new FormStudentManagers();
            SM.Show();
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            FormProjectManager PM = new FormProjectManager();
            PM.Show();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonReportStudents_Click(object sender, EventArgs e)
        {
            FormReportStudents RS = new FormReportStudents();
            RS.Show();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        



        private void buttonAssign_Click(object sender, EventArgs e)
        {
            FormAssignStudents RP = new FormAssignStudents();
            RP.Show();
        }

    

        private void buttonReportProjects_Click_1(object sender, EventArgs e)
        {
            FormReportProjects RP = new FormReportProjects();
            RP.Show();
        }
    }
}
