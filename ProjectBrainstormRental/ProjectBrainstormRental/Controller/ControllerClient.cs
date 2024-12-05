using Microsoft.Data.SqlClient;
using ProjectBrainstormRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBrainstormRental
{
    internal class ControllerClient
    {
        FormClient formclient;
        Client client;

        public ControllerClient(FormClient fclient)
        {
            formclient = fclient;
        }

        public void Include()
        {
            using (var db = new textC9Context())
            {
                Client client = new Client()
                {
                    Id = formclient.textBoxIDx.Text,
                    Nameclient = formclient.textBoxNamex.Text,
                    Lastname = formclient.textBoxLastnamex.Text,
                    Phonenumber = formclient.textBoxPhonenumberx.Text,
                    Direction = formclient.textBoxDirectionx.Text,
                    Statusclient = "A"
                };
                MessageBox.Show("The client has been found successfully", "Gift Found");
                db.Client.Add(client);
                db.SaveChanges();
            }

        }

        public void SearchClient()
        {
            textC9Context db = new textC9Context();
            string found = formclient.textBoxIDx.Text;

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
                formclient.textBoxIDx.Enabled = false;
                formclient.textBoxNamex.Text = client.Nameclient;
                formclient.textBoxLastnamex.Text = client.Lastname;
                formclient.textBoxPhonenumberx.Text = client.Phonenumber;
                formclient.textBoxDirectionx.Text = client.Direction;
                MessageBox.Show("The client has been found successfully", "Gift Found");
            }
            else
            {
                formclient.textBoxIDx.Enabled = true;
                MessageBox.Show("The client has not been found successfully", "Gift not Found");
            }

        }


        public void Clean()
        {
            formclient.textBoxIDx.Text = "";
            formclient.textBoxNamex.Text = "";
            formclient.textBoxLastnamex.Text = "";
            formclient.textBoxPhonenumberx.Text = "";
            formclient.textBoxDirectionx.Text = "";
        }



        public void Modify()
        {
            var db = new textC9Context();
            db.Client.Update(new Client()
            {
                Id = formclient.textBoxIDx.Text,
                Nameclient = formclient.textBoxNamex.Text,
                Lastname = formclient.textBoxLastnamex.Text,
                Phonenumber = formclient.textBoxPhonenumberx.Text,
                Direction = formclient.textBoxDirectionx.Text,
                Statusclient = "A"
            });
            db.SaveChanges();
            MessageBox.Show("The client have been successfully modified", "Client Update");

        }

                   
                   
        public void Delete()
        {
            using (var db = new textC9Context())
            {
                var found = db.Client.Find(formclient.textBoxIDx.Text);
                db.Client.Remove(found);
                db.SaveChanges();
                MessageBox.Show("The client was successfully eliminated", "Client Deleted");

            }
        }




    }



}
