using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VSLibraries
{
    public static class Palindrome
    {
        public static bool IsPalindrome(this string value)
        {
            if (value == null) throw new ArgumentNullException("value");
            value = Regex.Replace(value.ToLower().Replace(" ", ""), @"[^0-9a-zA-Z]+", "");
            return value.CheckPalindrome();
            
        }
        public static bool CheckPalindrome(this string value)
        {
            if (value.Length < 2) return true;

            if (value.First() == value.Last())
            {
                return value.Substring(1, value.Length - 2).IsPalindrome();
            }
            return false;
        }
    }
}
