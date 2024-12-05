using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_XavierSchool
{
    public static class Validation
    {

        public static void onlyLetters(KeyPressEventArgs e)
        {
            int asciiNum = e.KeyChar;
            if (char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Only Letters");
                e.Handled = true; ;
                return;
            }
        }

        public static void onlyNumbers(KeyPressEventArgs e)
        {
            int asciiNum = e.KeyChar;
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Only Numbers");
                e.Handled = true; ;
                return;
            }
        }
        
        public static Boolean dateComparator(DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value)
                return true;
            else
                return false;
        }
    }
}
