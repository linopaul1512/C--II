using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_XavierSchool
{
    public partial class FormProjectList : Form
    {
        public FormProjectList()
        {
            InitializeComponent();
            loadData(ProjectsRepository.projectsList());
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            loadData(ProjectsRepository.searchProject(textBoxSearch.Text));
        }
        public void loadData(List<Project> projectList)
        {
            var listP = projectList;
            fillInTable(listP);
        }
        public void fillInTable(List<Project> project)
        {
            dataGridViewProjectList.Rows.Clear();
            foreach (var studentX in project)
            {
                dataGridViewProjectList.Rows.Add(
                    studentX.code,
                    studentX.name,
                    studentX.maxStudents,
                    studentX.startingDate,
                    studentX.closingDate,
                    studentX.status);
            }
        }
    }
}
