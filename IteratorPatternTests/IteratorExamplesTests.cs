using Microsoft.VisualStudio.TestTools.UnitTesting;
using IteratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorPattern.Tests
{
    [TestClass()]
    public class IteratorExamplesTests
    {
        private string[] stocks;

        [TestInitialize]
        public void Setup()
        {
            stocks = new[] { "MSFT", "GOOG", "AAPL" };
        }

        [TestMethod()]
        public void ArrayIteration()
        {
            for (int i = 0; i < stocks.Length; i++)
            {
                Console.WriteLine(stocks[i]);
            }
            Assert.AreEqual(3, stocks.Length);
        }

        [TestMethod()]
        public void Enumerator()
        {
            IEnumerator enumerator = stocks.GetEnumerator();
            int count = 0;
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                count++;
            }
            Assert.AreEqual(3, count);
        }

        [TestMethod()]
        public void Foreach()
        {
            string laststock = string.Empty;
            foreach (var item in stocks)
            {
                laststock = item;
                Console.WriteLine(item);
            }
            Assert.AreEqual("AAPL", laststock);
        }

        [TestMethod()]
        public void CustomListTest()
        {
            var customList = new SuperCollection { "MSFT", "GOOG", "AAPL" };
            int count = 0;
            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList.Get(i));
                count++;
            }
            Assert.AreEqual(3, count);
        }

    }
}