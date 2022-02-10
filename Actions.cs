using System;
using System.Collections.Generic;


namespace FizzBuzz
{
    //class that contains actions
    public class Actions
    {

        // Accepts a list and returns the
        // required outputs
        public static string DoFizzBuzz(int num)
        {
            string word;

            if (num % 3 == 0 && num % 5 == 0)
            {
                word = "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                word = "Fizz";
            }
            else if (num % 5 == 0)
            {
                word = "Buzz";
            }
            else {
                word = num.ToString(); 
            }
            return word;
        }

        public static bool IsFizzBuzz(string Action)
        {
            if (Action == "FizzBuzz")
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        public static bool IsFizz(string Action)
        {
            if (Action == "Fizz")
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool IsBuzz(string Action)
        {
            if (Action == "Buzz")
            {
                return true;

            }
            else
            {
                return false;
            }
        }







    }
}
