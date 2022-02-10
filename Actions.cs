using System;
using System.Collections.Generic;


namespace FizzBuzz
{
    //class that contains actions
    public class Actions
    {

        // Accepts an integer and returns the
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

        // accepts an action and string
        // returns a bollean outcome dependent upon match
        public static bool FizzBuzzChecker(string expected, string Action)
        {
            if (Action == expected)
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
