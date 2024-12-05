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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonFormTheaterPlays_Click(object sender, EventArgs e)
        {
            FormTheater TE = new FormTheater();
            TE.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            FormReport RE = new FormReport();
            RE.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
