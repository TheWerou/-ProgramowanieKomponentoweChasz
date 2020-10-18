using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChashKomponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.GetPKpassword());
            int pass = this.GetPKpassword().getPasswordProcStrenght();
            Dictionary<String, bool> DictOfErrors = this.pKpassword1.getMapOfErrors();
            string outString = "";


            if (!DictOfErrors["GoodLenght"] || !DictOfErrors["Correct"])
            {
                outString += "Zła długość hasła lub hasło nie poprawne, ";
            }
            if(!DictOfErrors["BigLetters"])
            {
                outString += "Za mała ilość dużych liter, ";
            }
            if (!DictOfErrors["Numbers"])
            {
                outString += "Za mała ilość cyfr, ";
            }
            if (!DictOfErrors["NonLerrers"])
            {
                outString += "Za mała ilość symboli, ";
            }
            if (!DictOfErrors["NoRepats"])
            {
                outString += "Za duża liczba powtórzeń, ";
            }

            this.progressBar1.Value = pass;
            this.LogMenu.Text = outString;
        }


    }
}
