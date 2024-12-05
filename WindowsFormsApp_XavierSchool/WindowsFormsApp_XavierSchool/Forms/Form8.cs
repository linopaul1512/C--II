using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_XavierSchool.Forms
{
    public partial class FormAssignStudents : Form
    {
        public FormAssignStudents()
        {
            InitializeComponent();
        }

        private void buttonStudentList_Click(object sender, EventArgs e)
        {
            FormStudentList SL = new FormStudentList();
            SL.Show();
        }

        private void buttonProjectList_Click(object sender, EventArgs e)
        {
            FormProjectList PL = new FormProjectList();
            PL.Show();
        }
    }
}
