using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingName;

namespace _01.PrintingName_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string res = PrintingName.PrintingName.GetName("Pesho");
            Assert.AreEqual("Hello, Pesho!", res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string res = PrintingName.PrintingName.GetName("Gosho");
            Assert.AreEqual("Hello, Gosho!", res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string res = PrintingName.PrintingName.GetName("Kiro");
            Assert.AreEqual("Hello, Kiro!", res);
        }
    }
}
