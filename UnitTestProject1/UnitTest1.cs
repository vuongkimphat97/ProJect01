using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BT1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private int a,b,c,d;
        [TestInitialize]
        public void testmethod1()
        {
            this.a = 10;
            this.b = 5;
            this.c = -6;
            this.d = -11;
        }
        [TestMethod]
        public void testconghaisoduong()
        {
            maytinh call = new maytinh(this.a,this.b);
            int expected = 15;
            int actual = call.execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testconghaisoam()
        {
            maytinh call = new maytinh(this.c,this.d);
            int expected = -17;
            int actual = call.execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}
