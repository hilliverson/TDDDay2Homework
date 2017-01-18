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
                 new Book() { name = "Potter1",num=1,price=100}
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
                 new Book() { name = "Potter1",num=1,price=100},
                 new Book() { name = "Potter2",num=1,price=100}
               
            };
            var expected = 190;
            var actual = target.CaculateMoney(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBuyThreeBook()
        {
            var target = new PotterShop();
            List<Book> books = new List<Book>
            {
                 new Book() { name = "Potter1",num=1,price=100},
                 new Book() { name = "Potter2",num=1,price=100},
                 new Book() { name = "Potter3",num=1,price=100}

            };
            var expected = 270;
            var actual = target.CaculateMoney(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBuyFourBook()
        {
            var target = new PotterShop();
            List<Book> books = new List<Book>
            {
                 new Book() { name = "Potter1",num=1,price=100},
                 new Book() { name = "Potter2",num=1,price=100},
                 new Book() { name = "Potter3",num=1,price=100},
                 new Book() { name = "Potter4",num=1,price=100}

            };
            var expected = 320;
            var actual = target.CaculateMoney(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBuyFiveBook()
        {
            var target = new PotterShop();
            List<Book> books = new List<Book>
            {
                 new Book() { name = "Potter1",num=1,price=100},
                 new Book() { name = "Potter2",num=1,price=100},
                 new Book() { name = "Potter3",num=1,price=100},
                 new Book() { name = "Potter4",num=1,price=100},
                 new Book() { name = "Potter5",num=1,price=100}

            };
            var expected = 375;
            var actual = target.CaculateMoney(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test一二集各買了一本第三集買了兩本()
        {
            var target = new PotterShop();
            List<Book> books = new List<Book>
            {
                 new Book() { name = "Potter1",num=1,price=100},
                 new Book() { name = "Potter2",num=1,price=100},
                 new Book() { name = "Potter3",num=2,price=100},
 
            };
            var expected = 370;
            var actual = target.CaculateMoney(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test一買一本第二三集買了兩本()
        {
            var target = new PotterShop();
            List<Book> books = new List<Book>
            {
                 new Book() { name = "Potter1",num=1,price=100},
                 new Book() { name = "Potter2",num=2,price=100},
                 new Book() { name = "Potter3",num=2,price=100},
 
            };
            var expected = 460;
            var actual = target.CaculateMoney(books);
            Assert.AreEqual(expected, actual);
        }


    }
}
