using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labsheet10;

namespace UnitTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void Should_RestoreMoney_When_GivePositiveNumber()
        {
            var money = new Money(10);
            money.Restore(10);
            Assert.AreEqual(20, money.Current);
        }

        [TestMethod]
        public void Should_RestoreMoney_When_GiveNegativeNumber()
        {
            var money = new Money(10);
            money.Restore(-10);
            Assert.AreEqual(20, money.Current);
        }

        [TestMethod]
        public void Should_RemoveMoney_When_GivePositiveNumber()
        {
            var money = new Money(10);
            money.Remove(10);
            Assert.AreEqual(0, money.Current);
        }

        [TestMethod]
        public void Should_RemoveMoney_When_GiveNegativeNumber()
        {
            var money = new Money(10);
            money.Remove(-10);
            Assert.AreEqual(0, money.Current);
        }

        [TestMethod]
        public void Should_CurrentMoneyAsZero_When_WantToClearMoney()
        {
            var money = new Money(10);
            money.Clear();
            Assert.AreEqual(0, money.Current);
        }

        [TestMethod]
        public void Should_CurrentMoneyAsZero_When_RemoveMoneyGreaterThanCurrentMoney()
        {
            var money = new Money(10);
            money.Remove(20);
            Assert.AreEqual(0, money.Current);
        }

        [TestMethod]
        public void Should_DoNothingToCurrentMoney_When_FullRestore()
        {
            var money = new Money(10);
            money.FullRestore();
            Assert.AreEqual(10, money.Current);
        }
    }
}
