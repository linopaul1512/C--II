using FuturartTheaterInc.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuturartTheaterInc.Controller
{
    internal class ControllerTheater
    {

        FormTheater formTP;
        TheaterPlays theaterplays;

        public ControllerTheater(FormTheater form)
        {
            formTP = form;
        }


        public void Include()
        {
            using (var db = new textC10Context())
            {
                TheaterPlays theaterplays = new TheaterPlays()
                {
                    Code = formTP.textBoxCodex.Text,
                    Nametp = formTP.textBoxNamex.Text,
                    Authorsname = formTP.textBoxAuthorNamex.Text,
                    Releasedate = DateTime.Now,
                    Statex = formTP.textBoxStatex.Text,
                    City = formTP.textBoxCityx.Text,
                    Lastmodification = DateTime.Now,
                    Status = "A"
                };
                MessageBox.Show("The Theater Plays has been found successfully", "Theater Plays Found");
                db.TheaterPlays.Add(theaterplays);
                db.SaveChanges();
            }

        }
        public void Search()
        {
            textC10Context db = new textC10Context();
            string found = formTP.textBoxCodex.Text;

            try
            {
                theaterplays = db.TheaterPlays.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (theaterplays != null)
            {
                formTP.textBoxCodex.Enabled = false;
                formTP.textBoxNamex.Text = theaterplays.Nametp;
                formTP.textBoxAuthorNamex.Text = theaterplays.Authorsname;
                formTP.textBoxStatex.Text = theaterplays.Statex;
                formTP.textBoxCityx.Text = theaterplays.City;
                MessageBox.Show("The Theater Plays has been found successfully", "Gift Found");
            }
            else
            {
                formTP.textBoxCodex.Enabled = true;
                MessageBox.Show("The Theater Plays has not been found successfully", "Gift not Found");
            }

        }


        public void Clean()
        {
            formTP.textBoxCodex.Text = "";
            formTP.textBoxNamex.Text = "";
            formTP.textBoxAuthorNamex.Text = "";
            formTP.textBoxStatex.Text = "";
            formTP.textBoxCityx.Text = "";
        }

        public void Modify()
        {
            var db = new textC10Context();
            db.TheaterPlays.Update(new TheaterPlays()
            {
                Code = formTP.textBoxCodex.Text,
                Nametp = formTP.textBoxNamex.Text,
                Authorsname = formTP.textBoxAuthorNamex.Text,
                Releasedate = DateTime.Now,
                Statex = formTP.textBoxStatex.Text,
                City = formTP.textBoxCityx.Text,
                Lastmodification = DateTime.Now,
                Status = "A"
            });
            db.SaveChanges();
            MessageBox.Show("The Theater Plays have been successfully modified", "Client Update");

        }


        public void Delete()
        {
            using (var db = new textC10Context())
            {
                var found = db.TheaterPlays.Find(formTP.textBoxCodex.Text);
                db.TheaterPlays.Remove(found);
                db.SaveChanges();
                MessageBox.Show("The Theater Plays was successfully eliminated", "Client Deleted");
                Clean();
            }
        }











    }
}
