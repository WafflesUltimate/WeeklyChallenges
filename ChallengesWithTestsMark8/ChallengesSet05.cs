using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return Enumerable.Range(startNumber + 1, startNumber + 100).Where(x => x % n == 0).First();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if(business.TotalRevenue == 0) { business.Name = "CLOSED"; }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers.Length == 0 || numbers == null) { return false; }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1]) { return false; }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int result = 0;
            if (numbers == null || numbers.Length < 2) { return result; }

            for(int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0 && i + 1 < numbers.Length) { result += numbers[i + 1]; }
            }
            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length == 0) { return ""; }

            string sentence = "";

            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i].Trim();

                if (words[i].Length > 0 && i + 1 != words.Length) { sentence += words[i] + " "; }

                else if (words[i].Length > 0) { sentence += words[i] + '.'; }
            }

            return sentence; 
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> a = new List<double>();
            if (elements.Count < 4 || elements == null) { return a.ToArray(); }

            for (int i = 3; i < elements.Count; i += 4)
            {
                a.Add(elements[i]); 
                if(i + 4 >= elements.Count) { break; }
            }

            return a.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if(nums.Length < 2) { return false; }

            for (int i = 0; i < nums.Length; i++)
            {
               for(int h = 0; h < nums.Length; h++) 
               {
                    if(i == h && h + 1 < nums.Length) { h++; }
                    if (nums[i] + nums[h] == targetNumber) {  return true; }
               }   
            }
            return false;
        }
    }
}
