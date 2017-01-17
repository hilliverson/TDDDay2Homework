using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace PotterShoppingCart
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void TestBuyOneBook()
        {
            var target = new PotterShop();
            var book = "Potter1";
            var expected = 100;
            var actual = target.CaculateMoney(book);
            Assert.AreEqual(expected, actual);
        }
    }
}
