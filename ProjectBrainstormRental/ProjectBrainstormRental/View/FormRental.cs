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

namespace ProjectBrainstormRental.View
{
    public partial class FormRental : Form
    {
        ControllerRental controller;
        public FormRental()
        {
            InitializeComponent();
            controller = new ControllerRental(this);
        }

  

        private void buttonInclude_Click(object sender, EventArgs e)
        {
            controller.Include();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.Clean();
        }

        private void buttonsearchClient_Click(object sender, EventArgs e)
        {
            controller.SearchClient();
        }

        private void buttonSearchBrainEnhancers_Click(object sender, EventArgs e)
        {
            controller.SearchBE();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            controller.Calculate();
        }

        public TextBox textBoxCodex
        {
            get { return textBoxCode; }
            set { textBoxCode = value; }
        }

        public TextBox textBoxSerialNumberx
        {
            get { return textBoxSerialNumber; }
            set { textBoxSerialNumber = value; }
        }



        public TextBox textBoxNumberofHourx
        {
            get { return textBoxNumberofHour; }
            set { textBoxNumberofHour = value; }
        }



        public TextBox textBoxIDx
        {
            get { return textBoxID; }
            set { textBoxID = value; }
        }


        public TextBox textBoxNameClientx
        {
            get { return textBoxNameClient; }
            set { textBoxNameClient = value; }
        }
        public TextBox textBoxPriceperHourx
        {
            get { return textBoxPriceperHour; }
            set { textBoxPriceperHour = value; }
        }


        public TextBox textBoxTotalx
        {
            get { return textBoxTotal; }
            set { textBoxTotal = value; }
        }

    }
}
