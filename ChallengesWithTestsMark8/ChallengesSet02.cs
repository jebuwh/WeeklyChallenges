using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
             if(numbers == null || numbers.Count() == 0)
              {
                return 0;
              }
         
                var min = numbers.Min();
                var max = numbers.Max();
                return min + max;
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            foreach (var num in numbers)
            {
               sum += num;
            }
            if (numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                return sum;
            }
        }

        public int SumEvens(int[] numbers)
        {
            
            if(numbers == null)
            {
                return 0;
            }
            var sum = 0;
            foreach (var item in numbers)
            {
                if(item % 2 == 0)
                {
                    sum += item;
                }
                else if(item % -2 == 0)
                {
                    sum -= item;
                }
            }
            return sum;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            
            
            var num = numbers.Sum();
            if(num % 2 != 0)
            {
                return true;
            }
            else if(num % 2 == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number < 0)
            {
                return 0;
            }
            
            return number / 2;
        }
    }
}
