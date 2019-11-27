using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using VSLibraries;

namespace VSRestApi.Controllers
{
    public class VSRestApiController : ApiController
    {
        // GET: VSRestApi
        
        [HttpGet]
        [Route("palindrome/{input}")]
        public bool palindrome(string input)
        {
            return Palindrome.IsPalindrome(input);
        }

        [HttpGet]
        [Route("fizzbuzz/{fizzer}/{buzzer}/{input}")]
        public string fizzbuzz(int fizzer, int buzzer, int input)
        {
            return  FizzBuzz.CheckFizzBuzz(fizzer, buzzer,input);
        }

        [HttpGet]
        [Route("fizz/{fizzer}/{input}")]
        public string fizz(int fizzer, int input)
        {
            return FizzBuzz.CheckFizzOrBuzz(fizzer, input , "Fizz");
        }

        [HttpGet]
        [Route("buzz/{buzzer}/{input}")]
        public string buzz(int buzzer, int input)
        {
            return FizzBuzz.CheckFizzOrBuzz(buzzer, input, "Buzz");
        }
    }
}