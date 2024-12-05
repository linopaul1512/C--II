using System;
using System.Windows.Forms;
using WindowsPet.Controller;
using WindowsPet.Models2;

namespace WindowsFormsApp_Pets.Views
{
    public partial class FormGift : Form
    {
        Gift gift;
        Controller controller;
       
        public FormGift()
        {
            InitializeComponent();
            controller = new Controller(this);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            controller.Include();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            controller.Delete();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.Search();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            controller.Modify();
        }
    }
}
