﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber + 1; i <= startNumber + n; i++)
            {
                if (i % n == 0)
                    return i;
            }
            return 0;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool result = false;
            if (numbers == null)
                return false;
            else if (numbers.Length == 1)
                return true;
            else
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        result = false;
                        break;
                    }
                    else
                        result = true;
                }
            }
            return result;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
                return "";

            words = words.Where(x => !string.IsNullOrWhiteSpace(x) && x != " ").ToArray();

            if (!words.Any())
                return "";

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }
            return string.Join(" ", words) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> fourths = new List<double>();

            if (elements == null)
                return fourths.ToArray();

            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % 4 == 0)
                {
                    fourths.Add(elements[i]);
                }
            }
            return fourths.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                
                return false;
            }

            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;

                if (seen.Contains(complement))
                {
                    
                    return true;
                }

                seen.Add(num);
            }

            
            return false;
        }
    }
}
