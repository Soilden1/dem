using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expResult = 0;
            int actResult = MyClass.Add(0, 0);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }

        [TestMethod]
        public void TestMethod2()
        {
            int expResult = int.MaxValue;
            int actResult = MyClass.Add(int.MinValue, -1);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }

        [TestMethod]
        public void TestMethod3()
        {
            int expResult = 3;
            int actResult = MyClass.Add(2, 1);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }

        [TestMethod]
        public void TestMethod4()
        {
            int expResult = 4;
            int actResult = MyClass.Add(2, 2);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }

        [TestMethod]
        public void TestMethod5()
        {
            int expResult = 5;
            int actResult = MyClass.Add(3, 2);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }

        [TestMethod]
        public void TestMethod6()
        {
            int expResult = 8;
            int actResult = MyClass.Add(4, 4);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }

        [TestMethod]
        public void TestMethod7()
        {
            int expResult = 6;
            int actResult = MyClass.Add(3, 3);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }

        [TestMethod]
        public void TestMethod8()
        {
            int expResult = 14;
            int actResult = MyClass.Add(7, 7);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }

        [TestMethod]
        public void TestMethod9()
        {
            int expResult = 91;
            int actResult = MyClass.Add(90, 1);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }

        [TestMethod]
        public void TestMethod10()
        {
            int expResult = 108;
            int actResult = MyClass.Add(107, 1);
            Assert.AreEqual(expResult, actResult, "Сумма посчитана не верно");
        }
    }
}
