using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BT1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void testwithN0()
        {
            double expected = 1;
            double actual = Mypower.power(5, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testwithpositiveN1()
        {
            double expected = 4;
            double actual = Mypower.power(2, 2 );
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testwithpositiveN2()
        {
            double expected = 27;
            double actual = Mypower.power(3, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testwithpositiveN3()
        {
            double expected = 4;
            double actual = Mypower.power(-2, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testwithnegativeN4()
        {
            double expected = -8;
            double actual = Mypower.power(-2, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testwithnegativeN5()
        {
            double expected =-0.5;
            double actual = Mypower.power(-2,-1);
            Assert.AreEqual(expected, actual);
        }
    }
}
