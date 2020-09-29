using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int num = 0;
            foreach (var number in numbers)
            {
                if(number % 2 == 0)
                {
                    num += number;
                }
                else if(number % 2 != 0)
                {
                    num -= number;
                }
            }
            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strs = new string[4] { str1, str2, str3, str4 };
            string minValue = strs[0];
            foreach (var item in strs)
            {
                if(item.Length < minValue.Length)
                {
                    minValue = item;
                }
            }
            return minValue.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] nums = new int[4] { number1, number2, number3, number4 };
            return nums.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int a = sideLength1;
            int b = sideLength2;
            int c = sideLength3;
            
            if(a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsStringANumber(string input)
        {
            double outputnum = 0;
            bool result = double.TryParse(input, out outputnum);
            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if(objs.Count(s => s != null) >= objs.Count(s => s == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            List<int> evens = new List<int>();
            
            foreach (var even in numbers)
            {
                if(even % 2 == 0)
                {
                    evens.Add(even);
                }
            }
            if (evens.Count == 0)
            {
                return 0;
            }
            if (numbers.Length == 0)
            {
                return 0;
            }
            
            return evens.Average();
        }

        public int Factorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
             }
            int num = 1;
            while (number != 1)
            {
                num = num * number;
                number = number - 1;
            }
            return num;
        }
    }
}
