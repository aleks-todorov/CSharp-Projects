using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.CountingOccurenceOfNumberInArray_Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] numbers = { 2, 3, 4, 5, 4, 3, 3, 4, 5, 6 };
            int result = CountingOccurenceOfNumberInArray.CountingOccurenceOfNumberInArray.CountOccurence(3, numbers);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] numbers = { 43, 4, 3, 23, 43, 4, 3, 234, 43, 23, 2, 43 };
            int result = CountingOccurenceOfNumberInArray.CountingOccurenceOfNumberInArray.CountOccurence(43, numbers);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] numbers = {1,2,3,4,5,6,6,7,5,45,4,33,2,2,3,5 };
            int result = CountingOccurenceOfNumberInArray.CountingOccurenceOfNumberInArray.CountOccurence(100, numbers);
            Assert.AreEqual(0, result);
        }
    }
}
