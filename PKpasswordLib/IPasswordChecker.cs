using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKpasswordLib
{
    public interface IPasswordChecker
    {
        int check_proc_password_strenght(String password_to_set);

        Dictionary<String, Boolean> getMapOfErrors();

        void set_password_variables(int min_lenght_of_password, int min_big_letters, int min_amount_of_numbers, int max_repeats, int min_amount_of_non_letters);

        int getMin_amount_of_non_letters();

        void setMin_amount_of_non_letters(int min_amount_of_non_letters);

        int getMax_repeats();

        void setMax_repeats(int max_repaets);

        int getMin_lenght_of_password();

        void setMin_lenght_of_password(int min_lenght_of_password);

        int getMin_big_letters();

        void setMin_big_letters(int min_big_letters);

        int getMin_amount_of_numbers();

        void setMin_amount_of_numbers(int min_amount_of_numbers);

        bool check_lenght(String password_to_set);

        bool check_char_repeat(String password_2_set);

        bool check_if_correct_char(String password_2_set);

        bool check_if_big_char_included(String password_2_set);

        bool check_if_number_is_included(String password_2_set);

        bool check_if_non_latters_included(String password_2_set);
    }
}
