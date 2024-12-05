using ProjectBrainstormRental.Models;
using ProjectBrainstormRental.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBrainstormRental.Controller
{
    internal class ControllerReport
    {
        FormReport formreport;
        List<Rental> list;
        BrainEnhancers foundBE;
        textC9Context db = new textC9Context();
        Client client;
        double priceBE;
        string nameClient;
        public ControllerReport(FormReport form)
        {
            formreport = form;
        }

        public void listRental()
        {
            db = new textC9Context();
            list = db.Rental.ToList();
  
        }



        public void loadData()
        {
            listRental();
            double price=0;
            foreach (var rental in list)
            {
                foundBE = db.BrainEnhancers.Find(rental.Serialnumber);
                price = foundBE.Priceperhour;
                formreport.dataGridViewReportx.Rows.Add(
                    
                    rental.Id,
                    //client.Nameclient,
                    rental.Codex,
                    rental.Numberofhours,
                    rental.Serialnumber,
                    (price * rental.Numberofhours).ToString()
                    ) ; 
            }
        }


        public void consulterBrainEnhancers(Rental x)
        {
            foundBE = db.BrainEnhancers.Find(x.Serialnumber);
            priceBE = foundBE.Priceperhour;
        }

        public void consulterClient(Rental x)
        {
            client = db.Client.Find(x.Id);
            nameClient = client.Nameclient;
        }
    }
}
