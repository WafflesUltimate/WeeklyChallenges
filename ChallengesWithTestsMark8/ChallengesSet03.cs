using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(bool val in vals) 
            { 
                if(val == false) { return true; }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null) { return false; }   

            int oddSum = 0;
            foreach(int num in numbers)
            {
                if (num % 2 == 1 || num % 2 == -1) { oddSum += num; }
            }

            return (oddSum % 2 == 1 || oddSum % 2 == -1) ? true : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string lettersOfAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string upperLetterOfAlphabet = lettersOfAlphabet.ToUpper();
            string numbers = "0123456789";

            int number = 0;
            int upper = 0;
            int lower = 0;

            foreach (char character in password)
            {
               if (numbers.Contains(character)) { number = 1; }
               if(upperLetterOfAlphabet.Contains(character)) {  upper = 1; }
               if (lettersOfAlphabet.Contains(character)) {  lower = 1; }

               if (lower == 1 && upper == 1 && number == 1) { return true; }
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
                return(dividend == 0 || divisor == 0) ? 0 : dividend / divisor;  
        }

        public int LastMinusFirst(int[] nums)
        {
            List<int> secondNums = nums.ToList<int>();

            return secondNums[secondNums.Count - 1] - secondNums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsBelow100 = new List<int>();

            for(int i = 0; i < 100; i++) 
            {
                if(i % 2 == 1) { oddsBelow100.Add(i); }
            }

            return oddsBelow100.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
              words[i] = words[i].ToUpper();
            }
        }
    }
}
