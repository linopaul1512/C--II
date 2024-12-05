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
    public partial class FormStudentList : Form
    {
        public FormStudentList()
        {
            InitializeComponent();
            loadData(StudentsRepository.studentsList());
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            loadData(StudentsRepository.searchStudent(textBoxSearch.Text));
        }
        public void loadData(List<Student> studentsList)
        {
            var listS = studentsList;
            fillInTable(listS);
        }
        public void fillInTable(List<Student> student)
        {
            dataGridViewStudentList.Rows.Clear();
            foreach (var studentX in student)
            {
                dataGridViewStudentList.Rows.Add(
                    studentX.name,
                    studentX.name,
                    studentX.lastName,
                    studentX.ID,
                    studentX.phoneNumber,
                    studentX.birthDate,
                    studentX.admissionDate,
                    studentX.sex,
                    studentX.status);
            }
        }

        public int StudentsReport()
        {
            return dataGridViewStudentList.RowCount;
        }
    }
}
