using System;
using Xunit;
using FizzBuzz;

namespace TestFizzBuzz
{

    public class FizzBuzzTests
    {

        [Fact]
        public void FizzBuzz_Test_condition_checker()
        {
            string action = Actions.DoFizzBuzz(15);
            bool result = Actions.FizzBuzzChecker("FizzBuzz", action);
            Assert.True(result, "TEST FAILED");
        }

        [Fact]
        public void FizzBuzz_Test_condition_3()
        {
            string action = Actions.DoFizzBuzz(3);
            bool result = Actions.FizzBuzzChecker("Fizz",action);
            Assert.True(result, "TEST FAILED" );
        }

        [Fact]
        public void FizzBuzz_Test_condition_5()
        {
            string action = Actions.DoFizzBuzz(5);
            bool result = Actions.FizzBuzzChecker("Buzz", action);
            Assert.True(result, "TEST FAILED");
        }


    }
}
