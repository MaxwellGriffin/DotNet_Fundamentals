using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//% (remainder operator msdn c#) - search term

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Operators_And_Methods
    {
        [TestMethod]
        public void TestMethod1() //using + - * / %
        {
            int a = 2, b = 4, c;

            c = a + b;
            Assert.AreEqual(6, c);

            c = b - a;
            Assert.AreEqual(2, c);

            c = b * a;
            Assert.AreEqual(8, c);

            c = b / a;
            Assert.AreEqual(2, c);

            c = b % a;
            Assert.AreEqual(0, c);
        }

        [TestMethod] //testm tab tab
        public void AddTwoNumbersReturnSum_Test()
        {
            int sum = AddTwoNumbersReturnSum(3, 7);
            Console.WriteLine(sum);
            Assert.AreEqual(10, sum);
        }

        public int AddTwoNumbersReturnSum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        [TestMethod]
        public void SubtractTwoNumbersReturnSum_Test()
        {
            int sum = SubtractTwoNumbersReturnSum(7, 3);
            Console.WriteLine(sum);
            Assert.AreEqual(4, sum);
        }

        public int SubtractTwoNumbersReturnSum(int x, int y)
        {
            int result = x - y;
            return result;
        }
    }
}