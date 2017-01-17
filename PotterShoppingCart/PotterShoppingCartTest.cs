using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace PotterShoppingCart
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void TestBuyOneBook()
        {
            var target = new PotterShop();
            List<Book> books =new List<Book>
            {
                 new Book() { name = "Potter1"}
            };
            var expected = 100;
            var actual = target.CaculateMoney(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBuyTwoBook()
        {
            var target = new PotterShop();
            List<Book> books = new List<Book>
            {
                 new Book() { name = "Potter1"},
                 new Book() { name = "Potter2"}
               
            };
            var expected = 190;
            var actual = target.CaculateMoney(books);
            Assert.AreEqual(expected, actual);
        }
    }
}
