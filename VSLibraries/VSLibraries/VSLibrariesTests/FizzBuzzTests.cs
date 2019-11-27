using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSLibraries;
namespace VSLibrariesTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Give1GetEmpty()
        {
            var expected = "";
            var actual = FizzBuzz.CheckFizzBuzz(2,7,1);
            var actualfizz = FizzBuzz.CheckFizzOrBuzz(2, 1, "Fizz");
            var actualbuzz = FizzBuzz.CheckFizzOrBuzz(7, 1, "Buzz");
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actualfizz);
            Assert.AreEqual(expected, actualbuzz);
        }
        [TestMethod]
        public void Give2GetFizz()
        {
            var expected = "Fizz";
            var actual = FizzBuzz.CheckFizzBuzz(2, 7, 2);
            var actualfizz = FizzBuzz.CheckFizzOrBuzz(2, 2, "Fizz");
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actualfizz);
        }
        [TestMethod]
        public void Give7GetBuzz()
        {
            var expected = "Buzz";
            var actual = FizzBuzz.CheckFizzBuzz(2, 7, 7);
            var actualbuzz = FizzBuzz.CheckFizzOrBuzz(2, 2, "Buzz");
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actualbuzz);
        }
        [TestMethod]
        public void Give14GetFizzBuzz()
        {
            var expected = "Fizz,Buzz";
            var actual = FizzBuzz.CheckFizzBuzz(2, 7, 14);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Give5GetEmpty()
        {
            var expected = "";
            var actual = FizzBuzz.CheckFizzBuzz(2, 7, 5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Give0GetException()
        {
            FizzBuzz.CheckFizzBuzz(2, 7, 0);
            FizzBuzz.CheckFizzOrBuzz(2, 0, "Fizz");
            FizzBuzz.CheckFizzOrBuzz(7, 0, "Buzz");
        }
    }
}
