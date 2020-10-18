using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKpasswordLib
{
    class StrenghtPass: IPasswordChecker
    {
        private int min_lenght_of_password;
        private int min_big_letters;
        private int min_amount_of_numbers;
        private int max_repeats;
        private int min_amount_of_non_letters;

        private Dictionary<String, Boolean> MapOfErrors;

        public Dictionary<String, Boolean> getMapOfErrors()
        {
            return MapOfErrors;
        }

        public StrenghtPass(int min_lenght_of_password, int min_big_letters, int min_amount_of_numbers, int max_repeats, int min_amount_of_non_letters)
        {
            this.MapOfErrors = new Dictionary<String, Boolean>();
            this.preper_map();

            this.min_lenght_of_password = min_lenght_of_password;
            this.min_big_letters = min_big_letters;
            this.min_amount_of_numbers = min_amount_of_numbers;
            this.max_repeats = max_repeats;
            this.min_amount_of_non_letters = min_amount_of_non_letters;
        }
        public StrenghtPass()
        {
            this.MapOfErrors = new Dictionary<String, Boolean>();
            this.preper_map();

            this.min_lenght_of_password = 8;
            this.min_big_letters = 1;
            this.min_amount_of_numbers = 1;
            this.max_repeats = 2;
            this.min_amount_of_non_letters = 1;
        }

        private void preper_map()
        {
            this.MapOfErrors.Add("GoodLenght", false);
            this.MapOfErrors.Add("Correct", false);
            this.MapOfErrors.Add("NoRepats", false);
            this.MapOfErrors.Add("Numbers", false);
            this.MapOfErrors.Add("BigLetters", false);
            this.MapOfErrors.Add("NonLerrers", false);
        }

        private void clear_map()
        {

            this.MapOfErrors["GoodLenght"] = false;
            this.MapOfErrors["Correct"] = false;
            this.MapOfErrors["NoRepats"] = false;
            this.MapOfErrors["Numbers"] = false;
            this.MapOfErrors["BigLetters"] = false;
            this.MapOfErrors["NonLerrers"] = false;
        }

        public void set_password_variables(int min_lenght_of_password, int min_big_letters, int min_amount_of_numbers, int max_repeats, int min_amount_of_non_letters)
        {
            this.min_lenght_of_password = min_lenght_of_password;
            this.min_big_letters = min_big_letters;
            this.min_amount_of_numbers = min_amount_of_numbers;
            this.max_repeats = max_repeats;
            this.min_amount_of_non_letters = min_amount_of_non_letters;
        }

        public int getMin_amount_of_non_letters()
        {
            return min_amount_of_non_letters;
        }

        public void setMin_amount_of_non_letters(int min_amount_of_non_letters)
        {
            this.min_amount_of_non_letters = min_amount_of_non_letters;
        }

        public int getMax_repeats()
        {
            return max_repeats;
        }

        public void setMax_repeats(int max_repaets)
        {
            this.max_repeats = max_repaets;
        }

        public int getMin_lenght_of_password()
        {
            return min_lenght_of_password;
        }

        public void setMin_lenght_of_password(int min_lenght_of_password)
        {
            this.min_lenght_of_password = min_lenght_of_password;
        }

        public int getMin_big_letters()
        {
            return min_big_letters;
        }

        public void setMin_big_letters(int min_big_letters)
        {
            this.min_big_letters = min_big_letters;
        }

        public int getMin_amount_of_numbers()
        {
            return min_amount_of_numbers;
        }

        public void setMin_amount_of_numbers(int min_amount_of_numbers)
        {
            this.min_amount_of_numbers = min_amount_of_numbers;
        }

        public int check_proc_password_strenght(String password_to_set)
        {
            this.clear_map();
            int output = 0;

            if (this.basic_check(password_to_set))
            {
                output = 20;
                this.MapOfErrors["GoodLenght"] = true;
                this.MapOfErrors["Correct"] = true;

                if (this.check_if_big_char_included(password_to_set))
                {
                    output += 20;
                    this.MapOfErrors["BigLetters"] = true;

                }
                if (this.check_if_number_is_included(password_to_set))
                {
                    output += 20;
                    this.MapOfErrors["Numbers"] = true;
                }
                if (this.check_if_non_latters_included(password_to_set))
                {
                    output += 20;
                    this.MapOfErrors["NonLerrers"] = true;
                }
                if (this.check_char_repeat(password_to_set))
                {
                    output += 20;
                    this.MapOfErrors["NoRepats"] = true;
                }
            }
            else
            {
                return output;
            }

            return output;

        }

        private bool basic_check(String password_to_set)
        {
            return this.check_if_correct_char(password_to_set) && this.check_lenght(password_to_set);
        }

        public bool check_lenght(String password_to_set)
        {
            return password_to_set.Length >= this.min_lenght_of_password;
        }

        public bool check_char_repeat(String password_2_set)
        {
            HashSet<String> uniqchar = new HashSet<String>(password_2_set.Split().ToList());
            return password_2_set.Length == uniqchar.Count + (this.max_repeats - 1);

        }
        public bool check_if_correct_char(String password_2_set)
        {
            int helper;
            for (int i = 0; i < password_2_set.Length; i++)
            {
                helper = (int)password_2_set.ElementAt(i);
                if (!(helper > 32 && helper < 127))
                {
                    return false;
                }
            }
            return true;
        }
        public bool check_if_big_char_included(String password_2_set)
        {
            int counter = 0;
            int helper;
            for (int i = 0; i < password_2_set.Length; i++)
            {
                helper = (int)password_2_set.ElementAt(i);
                if (helper > 64 && helper < 91)
                {
                    counter += 1;
                }
            }

            return counter >= this.min_big_letters;

        }

        public bool check_if_number_is_included(String password_2_set)
        {
            int counter = 0;
            int helper;
            for (int i = 0; i < password_2_set.Length; i++)
            {
                helper = (int)password_2_set.ElementAt(i);
                if (helper > 48 && helper < 58)
                {
                    counter += 1;
                }
            }

            return counter >= this.min_amount_of_numbers;

        }

        public bool check_if_non_latters_included(String password_2_set)
        {
            int counter = 0;
            int helper;
            for (int i = 0; i < password_2_set.Length; i++)
            {
                helper = (int)password_2_set.ElementAt(i);
                bool first = helper > 32 && helper < 48;
                bool second = helper > 57 && helper < 65;
                bool third = helper > 90 && helper < 97;
                bool fourth = helper > 123 && helper < 127;

                if (first || second || third || fourth)
                {
                    counter += 1;
                }
            }
            return counter >= this.min_amount_of_non_letters;
        }
    }
}
