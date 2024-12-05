using ProjectEstudent.Controller;
using ProjectEstudent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEstudent
{
    public partial class FormReport : Form
    {
        ControllerReport controller;
        public FormReport()
        {
            InitializeComponent();
            controller = new ControllerReport(this);
            controller.loadData();
        }


        public DataGridView dataGridViewReportx
        {
            get { return dataGridViewReport; }
            set { dataGridViewReport = value; }
        }
        public TextBox textBoxCodeFalcultyx
        {
            get { return textBoxCodeFalculty; }
            set { textBoxCodeFalculty = value; }
        } 
        private void buttonSearch_Click(object sender, EventArgs e)
        {
           controller.search_studentes_faculties(textBoxCodeFalculty.Text);

        }

   
    }
}
