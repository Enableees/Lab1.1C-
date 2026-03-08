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
        public void ConvertToRublesAndKopecks_NumberLessThanMin_ReturnsError()
        {
            int number = 0;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("Некорректное значение. Введите число от 1 до 9999", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_NumberMoreThanMax_ReturnsError()
        {
            int number = 10000;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("Некорректное значение. Введите число от 1 до 9999", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_MinValuet()
        {
            int number = 1;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("0 рублей 1 копейка", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_MaxValue()
        {
            int number = 9999;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("99 рублей 99 копеек", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_Ruble_1()
        {
            int number = 101;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("1 рубль 1 копейка", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_Ruble_2()
        {
            int number = 201;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("2 рубля 1 копейка", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_Ruble_5()
        {
            int number = 501;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("5 рублей 1 копейка", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_RubleException11_14()
        {
            int number = 1101;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("11 рублей 1 копейка", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_Kopeck_1()
        {
            int number = 101;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("1 рубль 1 копейка", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_Kopeck_2()
        {
            int number = 102;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("1 рубль 2 копейки", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_Kopeck_5()
        {
            int number = 105;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("1 рубль 5 копеек", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_KopeckException11_14()
        {
            int number = 111;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("1 рубль 11 копеек", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_ZeroKopecks()
        {
            int number = 100;
            var result = Logic.ConvertToRublesAndKopecks(number);
            Assert.AreEqual("1 рубль 0 копеек", result);
        }

        [TestMethod()]
        public void ConvertToRublesAndKopecks_AllVariants()
        {
            Assert.AreEqual("1 рубль 0 копеек", Logic.ConvertToRublesAndKopecks(100));
            Assert.AreEqual("2 рубля 0 копеек", Logic.ConvertToRublesAndKopecks(200));
            Assert.AreEqual("5 рублей 0 копеек", Logic.ConvertToRublesAndKopecks(500));
            Assert.AreEqual("11 рублей 0 копеек", Logic.ConvertToRublesAndKopecks(1100));

            Assert.AreEqual("1 рубль 1 копейка", Logic.ConvertToRublesAndKopecks(101));
            Assert.AreEqual("1 рубль 2 копейки", Logic.ConvertToRublesAndKopecks(102));
            Assert.AreEqual("1 рубль 5 копеек", Logic.ConvertToRublesAndKopecks(105));
            Assert.AreEqual("1 рубль 11 копеек", Logic.ConvertToRublesAndKopecks(111));

            Assert.AreEqual("2 рубля 1 копейка", Logic.ConvertToRublesAndKopecks(201));
            Assert.AreEqual("5 рублей 1 копейка", Logic.ConvertToRublesAndKopecks(501));
            Assert.AreEqual("11 рублей 1 копейка", Logic.ConvertToRublesAndKopecks(1101));
        }
    }
}