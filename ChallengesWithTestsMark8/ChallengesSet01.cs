using System;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var subtractResult = minuend - subtrahend;
            return subtractResult;
        }

        public int Add(int number1, int number2)
        {
            var addResult = number1 + number2;
            return addResult;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            var smallestNumber = (number1 < number2 )? number1 : number2;
            return smallestNumber;
        }

        public long Multiply(long factor1, long factor2)
        {
            var multiplyResult = factor1 * factor2;
            return multiplyResult;
        }

        public string GetGreeting(string nameOfPerson)
        {
            string greeting;
            if (nameOfPerson == ""){
                 greeting = $"Hello!";
            }
            else {
                 greeting = $"Hello, {nameOfPerson}!";

            }
            return greeting;
        }

        public string GetHey()
        {
            var hey = "HEY!";
            return hey;
        }
    }
}
