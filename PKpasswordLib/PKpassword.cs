using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKpasswordLib
{
    public partial class PKpassword: UserControl
    {
        private IPasswordChecker passwordChecker;
        public PKpassword()
        {
            InitializeComponent();
            this.passwordChecker = new StrenghtPass();
            
        }
        public PKpassword(IPasswordChecker passwordChecker)
        {
            InitializeComponent();
            this.passwordChecker = passwordChecker;
        }
        public void set_passwordChecker_variables(int min_lenght_of_password, int min_big_letters, int min_amount_of_numbers, int max_repeats, int min_amount_of_non_letters)
        {
            this.passwordChecker.set_password_variables(
                    min_lenght_of_password,
                    min_big_letters,
                    min_amount_of_numbers,
                    max_repeats,
                    min_amount_of_non_letters);
        }
        void setPasswordChecker(IPasswordChecker passwordChecker)
        {
            this.passwordChecker = passwordChecker;
        }

        public int getPasswordProcStrenght()
        {
            return passwordChecker.check_proc_password_strenght(this.textBox1.Text);

            //todo System.NullReferenceException: „Odwołanie do obiektu nie zostało ustawione na wystąpienie obiektu.”
        }
        public Dictionary<String, Boolean> getMapOfErrors()
        {
            return passwordChecker.getMapOfErrors();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
