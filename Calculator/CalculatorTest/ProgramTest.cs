using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void Test_GetResult_chekSum()
        {
            double a = 5;
            double b = 9.7;
            char znak = '+';
            double result = 1;
            double expected = 15.7;

            double actual = Calculator.Program.GetResult(a, b, znak, result);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_GetResult_chekSub()
        {
            double a = 5.1;
            double b = 7.1;
            char znak = '-';
            double result = 1;
            double expected = -1;

            double actual = Calculator.Program.GetResult(a, b, znak, result);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_GetResult_chekMult()
        {
            double a = 5;
            double b = 9.7;
            char znak = '*';
            double result = 1;
            double expected = 49.5;

            double actual = Calculator.Program.GetResult(a, b, znak, result);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_GetResult_chekDiv()
        {
            double a = 11;
            double b = 5.5;
            char znak = '/';
            double result = 1;
            double expected = 3;

            double actual = Calculator.Program.GetResult(a, b, znak, result);

            Assert.AreEqual(expected, actual);
        }
    }
}
