using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class PotterShop
    {
        private int _potterPrice;//書本價錢
        public PotterShop()
        {
            _potterPrice = 100;
        }

        public double CaculateMoney(List<Book> books)
        {
            double TotalPrice = 0.0;   
            while (books.Count > 0)
            {
                if (BooksGroupBy(books) > 4)
                {
                    //五本不同的優惠價
                    TotalPrice+=FiveDifferentDiscount();
                }
                else if (BooksGroupBy(books) > 3)
                {
                    //四本不同的優惠價
                    TotalPrice += FourDifferentDiscount();
                }
                else if (BooksGroupBy(books) > 2)
                {
                    //三本不同的優惠價
                    TotalPrice += ThreeDifferentDiscount();
                }
                else if (BooksGroupBy(books) > 1)
                {
                    //兩本不同的優惠價
                    TotalPrice += TwoDifferentDiscount();
                }
                else
                {
                    //一般價格
                    TotalPrice += Normal();
                }
                books = DelBook(books);
            }

            return TotalPrice;

        }

        private List<Book> DelBook(List<Book> books)
        {
            List<Book> FilterBooks = new List<Book>();
            foreach(var book in books)
            {
                if(book.num>1)
                {
                    book.num = book.num - 1;
                    FilterBooks.Add(book);
                }
            }
            return FilterBooks;
        }

        

        private double Normal()
        {
            return 1 * _potterPrice;
        }

        private double TwoDifferentDiscount()
        {
            return 2 * _potterPrice * 0.95;
        }

        private double ThreeDifferentDiscount()
        {
            return 3 * _potterPrice * 0.9;
        }

        private double FourDifferentDiscount()
        {
            return 4 * _potterPrice * 0.8;
        }

        private double FiveDifferentDiscount()
        {
            return 5 * _potterPrice * 0.75;
        }

        private int BooksGroupBy(List<Book> books)
        {
            return books.GroupBy(i => i.name).Count();
        }

    }
}