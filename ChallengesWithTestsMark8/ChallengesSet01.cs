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

        public double Subtract(double num1, double num2)
        {
           
            return num1 - num2;
        }

        public int Add(int number1, int number2)
        {
           return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }
        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            return ("$How are you, {John}");
        }

        public string GetHey()
        {
            return ("$Hey employees, {Mark} {Brittany} ");
        }
    }
}
