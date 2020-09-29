using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            List<int> odds = new List<int>();
            foreach (var item in numbers)
            {
                if(item % 2 != 0)
                {
                    odds.Add(item);
                }
            }
            if(odds.Sum() % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if(password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char l = val.Last();
            return l;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            int[] range = Enumerable.Range(1, 100).ToArray();
            List<int> odd = new List<int>();
            foreach (var item in range)
            {
                if(item % 2 != 0)
                {
                    odd.Add(item);
                }
            }
            int[] odds = odd.ToArray();
            return odds;
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
