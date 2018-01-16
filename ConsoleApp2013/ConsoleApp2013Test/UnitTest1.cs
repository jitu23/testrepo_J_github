using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2013;

namespace ConsoleApp2013Test
{
    [TestClass]
    public class TestCalculation
    {
        [TestMethod]
        public void TestEmptyEntry()
        {
            Form1 f = new Form1();
            Assert.IsTrue(f.CheckEmptyEntry(" "), "true");
        }
        [TestMethod]
        public void TestNumbers()
        {
            Form1 f = new Form1();
            Assert.IsTrue(f.CheckNumber("5.0"), "true");
        }
        [TestMethod]
        public void TestAddition()
        {
            Form1 f = new Form1();
            var result = f.AddNumber(10, 30);
            Assert.AreEqual(40, result);
        }
    }
}
