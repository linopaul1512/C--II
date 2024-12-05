using Microsoft.Data.SqlClient;
using ProjectBrainstormRental.Models;
using ProjectBrainstormRental.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBrainstormRental.Controller
{
    internal class ControllerRental
    {
        FormRental formrental;
        Rental rental;
        Client client;
        BrainEnhancers brainEnhancers;



        public ControllerRental(FormRental form)
        {
            formrental = form;
        }

        public void Include()
        {
            using (var db = new textC9Context())
            {
                Rental RE = new Rental()
                {
                    Codex = formrental.textBoxCodex.Text,
                    Id = formrental.textBoxIDx.Text,
                    Serialnumber = formrental.textBoxSerialNumberx.Text,
                    Numberofhours = Int32.Parse(formrental.textBoxNumberofHourx.Text),
                    
                };
                MessageBox.Show("The Brain Enhancers has been found successfully", "Brain Enhancers  Found");
                db.Rental.Add(RE);
                db.SaveChanges();
            }


        }

        public void SearchBE()
        {
            textC9Context db = new textC9Context();
            string found = formrental.textBoxSerialNumberx.Text;

            try
            {
                brainEnhancers = db.BrainEnhancers.Find(found);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (brainEnhancers != null)
            {
                formrental.textBoxSerialNumberx.Enabled = false;
                formrental.textBoxSerialNumberx.Text = brainEnhancers.Serialnumber;
                formrental.textBoxPriceperHourx.Text = brainEnhancers.Priceperhour.ToString();
                MessageBox.Show("The Brain Enhancers  has been found successfully", "Brain Enhancers  Found");
            }
            else
            {
                formrental.textBoxSerialNumberx.Enabled = true;
                MessageBox.Show("The Brain Enhancers  has not been found successfully", "Brain Enhancers  not Found");
            }
        }

        public void Clean()
        {
            formrental.textBoxCodex.Text = "";
            formrental.textBoxIDx.Text = "";
            formrental.textBoxNameClientx.Text = "";
            formrental.textBoxSerialNumberx.Text = "";
            formrental.textBoxPriceperHourx.Text = "";
            formrental.textBoxNumberofHourx.Text = "";          
            formrental.textBoxTotalx.Text = "";
        }





        public void SearchClient()
        {
            textC9Context db = new textC9Context();
            string found = formrental.textBoxIDx.Text;

            try
            {
                client = db.Client.Find(found);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (client != null)
            {
                formrental.textBoxIDx.Enabled = false;
                formrental.textBoxIDx.Text = client.Id;
                formrental.textBoxNameClientx.Text = client.Nameclient;
                MessageBox.Show("The client has been found successfully", "Gift Found");
            }
            else
            {
                formrental.textBoxIDx.Enabled = true;
                MessageBox.Show("The client has not been found successfully", "Gift not Found");
            }

        }


        public void Calculate()
        {
            double price = double.Parse(formrental.textBoxPriceperHourx.Text);
            int quantity = int.Parse(formrental.textBoxNumberofHourx.Text);
            formrental.textBoxTotalx.Text = (price * quantity).ToString();

        }
    }
}
