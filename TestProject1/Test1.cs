using Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CompareTest()
        {
            int numb = 10000;
            var message = Logic.Compare(numb);
            Assert.AreEqual("Error", message);
        }
        [TestMethod()]
        public void CompareTest2()
        {
            int numb = 0;
            var message = Logic.Compare(numb);
            Assert.AreEqual("Error", message);
        }
        [TestMethod()]
        public void CompareTest3()
        {
            int numb = 1500;
            var message = Logic.Compare(numb);
            Assert.AreEqual($"15 rubles 0 kopecks", message);
        }
        [TestMethod()]
        public void CompareTest4()
        {
            int numb = 1521;
            var message = Logic.Compare(numb);
            Assert.AreEqual($"15 rubles 21 kopecks", message);
        }
    }
}