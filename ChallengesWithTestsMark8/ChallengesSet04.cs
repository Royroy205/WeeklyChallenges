using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int minLength = int.MaxValue;

            if (str1 != null && str1.Length < minLength)
            {
                minLength = str1.Length;
            }

            if (str2 != null && str2.Length < minLength)
            {
                minLength = str2.Length;
            }

            if (str3 != null && str3.Length < minLength)
            {
                minLength = str3.Length;
            }

            if (str4 != null && str4.Length < minLength)
            {
                minLength = str4.Length;
            }

            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = int.MaxValue;

            if (number1 < smallest)
            {
                smallest = number1;
            }

            if (number2 < smallest)
            {
                smallest = number2;
            }

            if (number3 < smallest)
            {
                smallest = number3;
            }

            if (number4 < smallest)
            {
                smallest = number4;
            }

            return smallest;
        }
    

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 + sideLength2 <= sideLength3) || (sideLength1 + sideLength3 <= sideLength2) || (sideLength2 + sideLength3 <= sideLength1))
            {
                return false;
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            return input != null && (double.TryParse(input, out double dInput));
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                
                return false; 
            }

            int nullCount = 0;
            int notNullCount = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
                else
                {
                    notNullCount++;
                }
            }

            return nullCount > notNullCount;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            double evenSum = 0;
            int evenCount = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                    evenCount++;
                }
            }
            return evenCount > 0 ? evenSum / evenCount : 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Factorial is not defined for negative numbers.");
            }

            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
