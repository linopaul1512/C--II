using ProjectEstudent.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEstudent.View
{
    public partial class FormReportSection : Form
    {
        ControllerReportSection controller;
        public FormReportSection()
        {
            InitializeComponent();
            controller = new ControllerReportSection(this);

        }

        public DataGridView dataGridViewReportX
        {
            get { return dataGridViewReport; }
            set { dataGridViewReport = value; }
        }

        public TextBox textBoxCodeAsignaturex
        {
            get { return textBoxCodeAsignature; }
            set { textBoxCodeAsignature = value; }
        }
    }
}
