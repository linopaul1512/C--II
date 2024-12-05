using FuturartTheaterInc.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuturartTheaterInc.View
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
    }
}
