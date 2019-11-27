using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSLibraries;

namespace VSLibrariesTests
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void PalindromeMethodExists()
        {
            "TestString".IsPalindrome();
        }
        [TestMethod]
        public void IfNullIsNotPalindrome()
        {
            string test = null;
            try
            {
                test.IsPalindrome();
                Assert.Fail();
            }
            catch(ArgumentNullException ex)
            {
                Assert.AreEqual("value", ex.ParamName);
            }
        }
        [TestMethod]
        public void EmptyStringIsPalindrome()
        {
            var result = string.Empty.IsPalindrome();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TwoLetterIsNotPalindrome()
        {
            var result = "ab".IsPalindrome();
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void OneLetterIsPalindrome()
        {
            var result = "a".IsPalindrome();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TwoLetterIsPalindrome()
        {
            var result = "aa".IsPalindrome();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SimpleStringIsPalindrome()
        {
            var result = "dad".IsPalindrome();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void WordIsNotPalindrome()
        {
            var result = "word".IsPalindrome();
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void PalindromeEvenSpaceTest()
        {
            var result = "Able was I ere I saw Elba".IsPalindrome();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PalidromeAnyTest()
        {
            var unevenspacedMcString = "Mr Owl ate my metal worm".IsPalindrome();
            Assert.IsTrue(unevenspacedMcString);

            var evenspacedlcString = "able was i ere i saw elba".IsPalindrome();
            Assert.IsTrue(evenspacedlcString);

            var NotPalindromeString = "Dad".CheckPalindrome();
            Assert.IsFalse(NotPalindromeString);

            var PalindromeString = "dad".CheckPalindrome();
            Assert.IsTrue(PalindromeString);

        }
    }
   
}
