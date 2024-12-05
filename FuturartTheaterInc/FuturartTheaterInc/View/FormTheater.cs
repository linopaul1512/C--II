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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace FuturartTheaterInc
{
    public partial class FormTheater : Form
    {
        ControllerTheater controller;

        public FormTheater()
        {
            InitializeComponent();
            controller = new ControllerTheater(this);

        }

        public TextBox textBoxCodex
        {
            get { return textBoxCode; }
            set { textBoxCode = value; }
        }

        public TextBox textBoxNamex
        {
            get { return textBoxName; }
            set { textBoxName = value; }
        }

        public TextBox textBoxAuthorNamex
        {
            get { return textBoxAuthorName; }
            set { textBoxAuthorName = value; }
        }
        

        
        public TextBox textBoxStatex
        {
            get { return textBoxState; }
            set { textBoxState = value; }
        }

        public TextBox textBoxCityx
        {
            get { return textBoxCity; }
            set { textBoxCity = value; }
        }

        private void buttonInclude_Click(object sender, EventArgs e)
        {
            controller.Include();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.Clean();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            controller.Modify();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.Search();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            controller.Delete();
        }
    }
}
