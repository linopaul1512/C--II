using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBrainstormRental.View
{
    public partial class FormMenu : Form
    {


        public FormMenu()
        {
            InitializeComponent();

        }

        
        

        private void buttonformBrainEnhancers_Click(object sender, EventArgs e)
        {
            FormBrainEnhancers BE = new FormBrainEnhancers();
            BE.Show();
        }

        private void buttonFromRental_Click(object sender, EventArgs e)
        {
            FormRental RE = new FormRental();
            RE.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFormClient_Click(object sender, EventArgs e)
        {
            FormClient CL = new FormClient();
            CL.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            FormReport RE = new FormReport();
            RE.Show();
        }
    }
}
