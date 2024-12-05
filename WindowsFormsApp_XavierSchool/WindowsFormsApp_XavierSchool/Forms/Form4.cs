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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_XavierSchool
{
    public partial class FormProjectManager : Form
    {
        Random random;
        string randomNumber, code, stats;

        public FormProjectManager()
        {
            InitializeComponent();
            dateTimePickerSD.CustomFormat = "dd/MM/yyyy";
            dateTimePickerSD.Format = DateTimePickerFormat.Custom;
            dateTimePickerCD.CustomFormat = "dd/MM/yyyy";
            dateTimePickerCD.Format = DateTimePickerFormat.Custom;
            random = new Random();
            randomNumber = random.Next().ToString();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            FormProjectList PL = new FormProjectList();
            PL.Show();
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
            if (File.Exists(ProjectsRepository.fileName))
            {
                if (ProjectsRepository.projectsCode(code) == null)
                {
                    ProjectsRepository.addProject(instanciateProjects());
                    MessageBox.Show("Project saved");
                    clean();
                }
                else
                {
                    buttonSave_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Project saved");
                clean();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnable.Checked)
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
            var project = ProjectsRepository.projectsCode(textBoxCode.Text);
            if (project == null)
            {
                dateTimePickerSD.Text = project.startingDate;
                textBoxName.Text = project.name;
                dateTimePickerCD.Text = project.closingDate;
                textBoxMaxStudents.Text = project.maxStudents.ToString();

                textBoxCode.Enabled = false;
            }
            else
            {
                MessageBox.Show("Code Not Found!!!");
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var project = ProjectsRepository.projectsCode(textBoxCode.Text);
            if (project != null)
            {
                if (dateTimePickerSD.Value > dateTimePickerCD.Value)
                {
                    ProjectsRepository.projectsModify(textBoxCode.Text, instanciateProjects());
                    clean();
                    MessageBox.Show("The Project has been modified successfully");
                    checkBoxEnable.Checked = false;
                }
                else
                {
                    MessageBox.Show("The closing date can't be the same or before as the starting date");
                }
            }
            else
            {
                MessageBox.Show("Code Not Found!!!");
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {

        }

        private void buttonList_Click_1(object sender, EventArgs e)
        {
            FormProjectList PL = new FormProjectList();
            
        }

        public Project instanciateProjects()
        {
            if (dateTimePickerSD.Value <= DateTime.Now)
                stats = "Active";
            else
                stats = "Inactive";

            Project projects = new Project()
            {
                code = randomNumber,
                name = textBoxName.Text,
                maxStudents = int.Parse(textBoxMaxStudents.Text),
                startingDate = dateTimePickerSD.Text,
                closingDate = dateTimePickerCD.Text,
                status = stats
            };
            return projects;
        }

        public void clean()
        {
            textBoxCode.Clear();
            textBoxName.Clear();
            checkBoxEnable.Checked = false;
            checkBoxFinish.Checked = false;
        }
    }
}
