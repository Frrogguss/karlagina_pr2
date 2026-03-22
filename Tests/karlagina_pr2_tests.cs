using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using karlagina_pr2;

namespace karlagina_pr2_tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Test_Add()
        {
            dynamic result = Core.Exicute(8, '+', 3);
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void Test_Subtract()
        {
            dynamic result = Core.Exicute(10, '-', 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            dynamic result = Core.Exicute(7, '*', 9);
            Assert.AreEqual(63, result);
        }

        [TestMethod]
        public void Test_Divide()
        {
            dynamic result = Core.Exicute(25, '/', 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Test_Power()
        {
            dynamic result = Core.Exicute(2, '^', 2);
            Assert.AreEqual(4, result);
        }
    }
}
