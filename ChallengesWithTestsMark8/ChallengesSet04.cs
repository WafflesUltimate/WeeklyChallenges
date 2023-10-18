using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int finalSum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0) { finalSum += number; }
                else { finalSum -= number; }
            }
            return finalSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            IEnumerable<string> strings = new List<string>() { str1, str2, str3, str4 };
            return strings.Min(y => y.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            IEnumerable<int> numbers = new List<int>() { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
           var a = sideLength1;
           var b = sideLength2;
           var c = sideLength3;

           if (a < 0 || a == 0 || b < 0 || b == 0 || c < 0 || c == 0) { return false; }

           return (a + b > c && a + c > b && b + c > a) ? true : false;     
           
        }

        public bool IsStringANumber(string input)
        {
            bool result;
            int test;
            double tester;

            if (input == null) { return false; }

            result = int.TryParse(input, out test);
            if (input.Contains('.')) { result = double.TryParse(input, out tester); }

            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var list = objs.ToList();
            return (list.Count(y => y == null) > list.Count(y => y != null)) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
           if (numbers == null) { return 0; }

           List<int> g = numbers.ToList();

           g.RemoveAll(y => y % 2 == 1);
           if (g.Count == 0) { return 0; }

           return g.Where(y => y % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if (number < 0) { throw new ArgumentOutOfRangeException(); }

            int factorial = 1;
            for(int i = number; i > 0; i--) 
            {
                factorial *= i; 
            }
            return factorial;
        }
    }
}
