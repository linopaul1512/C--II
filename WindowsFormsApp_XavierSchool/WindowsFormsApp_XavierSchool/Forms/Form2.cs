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
    public partial class FormStudentManagers : Form
    {
        Random random;
        string randomNumber, sexx, code;
        public FormStudentManagers()
        {
            InitializeComponent();
            dateTimePickerBD.CustomFormat = "dd/MM/yyyy";
            dateTimePickerBD.Format = DateTimePickerFormat.Custom;
            dateTimePickerAD.CustomFormat = "dd/MM/yyyy";
            dateTimePickerAD.Format = DateTimePickerFormat.Custom;
            random = new Random();
            randomNumber = random.Next().ToString();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            FormStudentList SL = new FormStudentList();
            SL.Show();
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.onlyNumbers(e);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.onlyLetters(e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            randomNumber = random.Next().ToString();
            code = randomNumber;
            if (File.Exists(StudentsRepository.fileName))
            {
                if (StudentsRepository.studentsCode(code) != null)
                {
                    StudentsRepository.addStudent(instanciateStudents());
                    MessageBox.Show("Student saved");
                    clean();
                }
                else
                {
                    buttonSave_Click(sender, e);
                }
            }
            
            {
                StudentsRepository.addStudent(instanciateStudents());
                MessageBox.Show("Student saved");
                clean();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnabled.Checked)
            {
                textBoxCode.Enabled = true;
                buttonModify.Enabled = true;
                buttonSearch.Enabled = true;
            }
            else
            {
                textBoxCode.Enabled = false;
                buttonModify.Enabled = false;
                buttonSearch.Enabled = false;
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var student = StudentsRepository.studentsCode(textBoxCode.Text);
            if (student != null)
            {
                dateTimePickerBD.Text = student.birthDate;
                textBoxName.Text = student.name;
                dateTimePickerAD.Text = student.admissionDate;
                if (student.sex == "Female")
                    radioButtonFemale.Checked=true;
                else
                    radioButtonMale.Checked=true;
                textBoxAddress.Text = student.address;
                textBoxID.Text = student.ID;
                textBoxLastName.Text = student.lastName;
                textBoxPhoneNumber.Text = student.phoneNumber;

                textBoxCode.Enabled = false;
            }
            else
            {
                MessageBox.Show("Code Not Found!!!");
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var shimmer = StudentsRepository.studentsCode(textBoxCode.Text);
            if (shimmer != null)
            {
                if (dateTimePickerBD.Value < dateTimePickerAD.Value)
                {
                    StudentsRepository.studentsModify(textBoxCode.Text, instanciateStudents());
                    clean();
                    MessageBox.Show("The Student has been modified successfully");
                    checkBoxEnabled.Checked = false;
                }
                else
                {
                    MessageBox.Show("The admission date can't be the same or before as the birth date");
                }
            }
            else
            {
                MessageBox.Show("Code Not Found!!!");
            }
        }

        private void buttonConsult_Click(object sender, EventArgs e)
        {
            FormConsult consult = new FormConsult();
            consult.Show();
        }

        private void groupBoxStudentsData_Enter(object sender, EventArgs e)
        {

        }

        public Student instanciateStudents()
        {
            if (radioButtonFemale.Checked)
                sexx = "Female";
            else
                sexx = "Male";

            Student students = new Student()
            {
                code = randomNumber,
                name = textBoxName.Text,
                lastName = textBoxLastName.Text,
                ID = textBoxID.Text,
                phoneNumber = textBoxPhoneNumber.Text,
                address = textBoxAddress.Text,
                birthDate = dateTimePickerBD.Text,
                admissionDate = dateTimePickerAD.Text,
                sex = sexx,
                status = "No Project"
            };
            return students;
        }

        public void clean()
        {
            textBoxCode.Clear();
            textBoxAddress.Clear();
            textBoxID.Clear();
            textBoxLastName.Clear();
            textBoxName.Clear();
            textBoxPhoneNumber.Clear();
            dateTimePickerAD.ResetText();
            dateTimePickerBD.ResetText();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            checkBoxEnabled.Checked = false;
        }
    }
}
