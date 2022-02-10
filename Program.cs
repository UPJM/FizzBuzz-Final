using System;
using System.Collections.Generic;


namespace FizzBuzz
{
    class program
    {

        public static void Main(string[] args)
        {
            var data = Data.DataList(1, 100);
            foreach (var number in data) {
                var output = Actions.DoFizzBuzz(number);
                Console.WriteLine(output);
            }

        }
    }

 }



