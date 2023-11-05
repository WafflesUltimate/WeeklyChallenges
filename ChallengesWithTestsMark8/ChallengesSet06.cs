using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words.Contains(null) || words == null){  return false; }

            string[] wordsArray = words.ToArray();
            if (ignoreCase) 
            {
               for (int i = 0; i < words.Count(); i++) { wordsArray[i] = wordsArray[i].ToLower(); }    
            }
            return (wordsArray.Contains(word))? true : false;
        }

        public bool IsPrimeNumber(int num)
        {
            if(num == 1) { return false; }
            else if(num == 2 || num == 3) { return true; }
            return (num % 2 != 0 && num % 3 != 0 && num > 0)? true : false; 
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j) 
                    {
                        uindex = false;
                    }
                }
                if (uindex) { index = i; }
            }   
   
           return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if ((numbers[i] != numbers[j]) && i != j) { break; }
                    currentCount++;
                }

                if(currentCount > count) { count = currentCount; }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
           List<double> doubles = new List<double>();
           int i = n - 1;
           if (elements.Count() < n || n <= 0 || elements == null) { return doubles.ToArray();  }

           while(i < elements.Count) 
           {
                doubles.Add(elements[i]);
                i += n;
                if (i >= elements.Count) { break; }
           }
           return doubles.ToArray();
        }
    }
}
