using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Pets.Views;
using WindowsPet.Models2;

namespace WindowsPet.Controller
{
    internal class Controller
    {

        FormGift formgift;
        Gift gift;
        public Controller(FormGift x)
        {
            formgift = x;
        }

        public void Include()
        {
            using (var db = new textC8Context())
            {
                Gift gift = new Gift()
                {
                    Codegift = formgift.textBoxIdGift.Text,
                    Descriptiongif = formgift.textBoxDescriptionGift.Text,
                    Dategif = DateTime.Now,
                    Statusgif = "A"
                };
                db.Gift.Add(gift);
                db.SaveChanges();
            }
        }


     

        public void Modify()
        {
            var db = new textC8Context();
            db.Gift.Update(new Gift()
            {
                Codegift = formgift.textBoxIdGift.Text,
                Descriptiongif = formgift.textBoxDescriptionGift.Text,
                Dategif = DateTime.Now,
                Statusgif = "A"
            });
            db.SaveChanges();
            MessageBox.Show("The gifts have been successfully modified", "Gift Update"); 

        }

        public void Delete()
        {
            using (var db = new textC8Context())
            {
                var found = db.Gift.Find(formgift.textBoxIdGift.Text);
                db.Gift.Remove(found);
                db.SaveChanges();
                MessageBox.Show("The gift was successfully eliminated", "Gift Deleted");

            }
        }

        public void Search()
        {
            var db = new textC8Context();
            string idgift = formgift.textBoxIdGift.Text;
            var gift = db.Gift.Find(idgift);
            if(gift != null)
            {
                formgift.textBoxIdGift.Enabled = false;
                formgift.textBoxDescriptionGift.Enabled = false;
                formgift.textBoxDescriptionGift.Text = gift.Descriptiongif;
                MessageBox.Show("The gift has been found successfully", "Gift Found");
            }
            else
            {
                formgift.textBoxIdGift.Enabled = true;
                formgift.textBoxDescriptionGift.Enabled = true;
                MessageBox.Show("The gift has not been found successfully", "Gift not Found");
            }


        }





    }

}



