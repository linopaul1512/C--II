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
    internal class ControllerBrainEnhancers
    {
        FormBrainEnhancers formbe;
        BrainEnhancers brainEnhancers;

        public ControllerBrainEnhancers(FormBrainEnhancers form)
        {
           formbe = form;
        }

        public void Include()
        {
            using (var db = new textC9Context())
            {
                BrainEnhancers BE = new BrainEnhancers()
                {
                    Serialnumber = formbe.textBoxSerialNumberx.Text,
                    Model = formbe.textBoxModelx.Text,
                    Percentageimprovement = Double.Parse(formbe.textBoxPercentageImprovementx.Text),
                    Priceperhour = Double.Parse(formbe.textBoxPriceHourx.Text),
                    Statuxbrain = "A"
                };
                MessageBox.Show("The Brain Enhancers has been found successfully", "Brain Enhancers  Found");
                db.BrainEnhancers .Add(BE);
                db.SaveChanges();
            }


        }

        public void Search()
        {
            textC9Context db = new textC9Context();
            string found = formbe.textBoxSerialNumberx.Text;

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
                formbe.textBoxSerialNumberx.Enabled = false;
                formbe.textBoxModelx.Text = brainEnhancers.Model;
                formbe.textBoxPercentageImprovementx.Text = brainEnhancers.Percentageimprovement.ToString();
                formbe.textBoxPriceHourx.Text = brainEnhancers.Priceperhour.ToString();
               
                MessageBox.Show("The Brain Enhancers  has been found successfully", "Brain Enhancers  Found");
            }
            else
            {
                formbe.textBoxSerialNumberx.Enabled = true;
                MessageBox.Show("The Brain Enhancers  has not been found successfully", "Brain Enhancers  not Found");
            }
        }

        public void Clean()
        {
            formbe.textBoxSerialNumberx.Text = "";
            formbe.textBoxModelx.Text = "";
            formbe.textBoxPercentageImprovementx.Text = "";
            formbe.textBoxPriceHourx.Text = "";
        }



        public void Modify()
        {
            var db = new textC9Context();
            db.BrainEnhancers.Update(new BrainEnhancers()
            {
                Serialnumber = formbe.textBoxSerialNumberx.Text,
                Model = formbe.textBoxModelx.Text,
                Percentageimprovement = float.Parse(formbe.textBoxPercentageImprovementx.Text),
                Priceperhour = float.Parse(formbe.textBoxPriceHourx.Text),
                Statuxbrain = "A"
            });
            db.SaveChanges();
            MessageBox.Show("The Brain Enhancers have been successfully modified", "Brain Enhancers Update");

        }



        public void Delete()
        {
            using (var db = new textC9Context())
            {
                var found = db.BrainEnhancers.Find(formbe.textBoxSerialNumberx.Text);
                db.BrainEnhancers.Remove(found);
                db.SaveChanges();
                MessageBox.Show("The Brain Enhancers was successfully eliminated", "Brain Enhancers Deleted");

            }
        }


    }
    }
