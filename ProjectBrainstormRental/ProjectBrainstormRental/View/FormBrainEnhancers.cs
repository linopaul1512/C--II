using ProjectBrainstormRental.Controller;
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

namespace ProjectBrainstormRental.View
{
    public partial class FormBrainEnhancers : Form
    {
        ControllerBrainEnhancers controller;
        public FormBrainEnhancers()
        {
            InitializeComponent();
            controller = new ControllerBrainEnhancers(this);
        }


        public TextBox textBoxSerialNumberx
        {
            get { return textBoxSerialNumber; }
            set { textBoxSerialNumber = value; }
        }

        public TextBox textBoxModelx
        {
            get { return textBoxModel; }
            set { textBoxModel = value; }
        }

        public TextBox textBoxPercentageImprovementx
        {
            get { return textBoxPercentageImprovement; }
            set { textBoxPercentageImprovement = value; }
        }        

        public TextBox textBoxPriceHourx
        {
            get { return textBoxPriceHour; }
            set { textBoxPriceHour = value; }
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
