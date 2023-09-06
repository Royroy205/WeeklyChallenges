using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }
    

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }    

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers != null && numbers.Count() > 0 ? numbers.Max() + numbers.Min() : 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }
    

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            //refactored to foreach rather than for loop
            int evensSum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evensSum += num;
                }
            }
            return evensSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers != null && numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1) return 0;

            long count = 0;
            for (long i = 1; i < number; i += 2)
            {
                count++;
            }

            return count;
        }
    }
}
