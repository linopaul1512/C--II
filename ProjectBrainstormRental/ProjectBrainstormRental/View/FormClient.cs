using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;

namespace ProjectBrainstormRental
{
    public partial class FormClient : Form
    {
        ControllerClient controller;
        public FormClient()
        {
            InitializeComponent();
            controller = new ControllerClient(this);

        }

        public TextBox textBoxIDx
        {
            get { return textBoxID; }
            set { textBoxID = value; }
        }

        public TextBox textBoxNamex
        {
            get { return textBoxName; }
            set { textBoxName = value; }
        }

        public TextBox textBoxLastnamex
        {
            get { return textBoxLastname; }
            set { textBoxLastname = value; }
        }


        public TextBox textBoxPhonenumberx
        {
            get { return textBoxPhonenumber; }
            set { textBoxPhonenumber = value; }
        }

        public TextBox textBoxDirectionx
        {
            get { return textBoxDirection; }
            set { textBoxDirection = value; }
        }

        private void buttonInclude_Click(object sender, EventArgs e)
        {
            controller.Include();
        }
       

        private void buttonClean_Click_1(object sender, EventArgs e)
        {
            controller.Clean();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.SearchClient();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            controller.Modify();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            controller.Delete();
        }
    }

}
