using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSLibraries
{
    public static class FizzBuzz
    {
        public static string CheckFizzBuzz(int a, int b, int i)
        {
            if (i < 1)throw new IndexOutOfRangeException();
            if (i % a == 0 && i % b == 0) return "Fizz,Buzz";
            if (i % a == 0) return "Fizz";
            if (i % b == 0) return "Buzz";
            if (i == 1 || i % a > 0 || i % b > 0) return string.Empty;
            return string.Empty; 
        }
        public static string CheckFizzOrBuzz(int a, int i, string b)
        {
            if (i < 1) throw new IndexOutOfRangeException();
            if (i % a == 0) return b;
            return string.Empty;
        }
        
    }
}
