using ProjectEstudent.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEstudent.View
{
    public partial class FormReportAsignatures : Form
    {
        ControllerReportAsignature controller;
        public FormReportAsignatures()
        {
            InitializeComponent();
            controller = new ControllerReportAsignature(this);
            controller.loadData();
        }

        
        public DataGridView dataGridViewAsignaturex
        {
            get { return dataGridViewAsignature; }
            set { dataGridViewAsignature = value; }
        }

        public TextBox textBoxCodeAsignaturex
        {
            get { return textBoxCodeStudent; }
            set { textBoxCodeStudent = value; }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.search_students_asignatures(textBoxCodeAsignaturex.Text);
        }

        private void buttoncalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
