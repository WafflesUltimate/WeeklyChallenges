using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           string lettersOfAlphabet = "abcdefghijklmnopqrstuvwxyz";
           string nonLetters = "0123456789`~!@#$%^&*()-_=+[{]}|;:',<.>/?";
           string g = c.ToString();

           if(lettersOfAlphabet.Contains(g.ToLower())) { return true; }
           else { return false; }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 == 1 || num % 2 == -1) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
           if (numbers == null){  return 0; }
           return (numbers.Count() == 0) ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int i = str2.Length;
            int b = str1.Length;
            return (i > b) ? b : i;
        }

        public int Sum(int[] numbers)
        {
             return (numbers != null) ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0; 
            if(numbers == null) { return 0; }    
            for(int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0) 
                { 
                    sum += numbers[i];  
                }   
            }
            return sum; 
        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null) { return false; }
            int sum = numbers.Sum();
            return (sum % 2 == 1 || sum % 2 == -1) ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            long i = 0;
            while(i < number)
            {
                if(i % 2 == 1 && i % 2 != -1) {  count++; }

                i++;
            }
            return count;
        }
    }
}
