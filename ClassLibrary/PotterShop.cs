using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class PotterShop
    {
       
        public double CaculateMoney(List<Book> books)
        {
            double TotalPrice = 0.0;   
            while (books.Count > 0)
            {
                if (BooksGroupBy(books) > 4)
                {
                    //五本不同的優惠價
                    TotalPrice += Discount(books,GetDiscountNum(4));
                }
                else if (BooksGroupBy(books) > 3)
                {
                    //四本不同的優惠價
                    TotalPrice += Discount(books,GetDiscountNum(3));
                }
                else if (BooksGroupBy(books) > 2)
                {
                    //三本不同的優惠價
                    TotalPrice += Discount(books, GetDiscountNum(2));
                }
                else if (BooksGroupBy(books) > 1)
                {
                    //兩本不同的優惠價
                    TotalPrice += Discount(books, GetDiscountNum(1));
                }
                else
                {
                    //一般價格
                    TotalPrice += Discount(books, GetDiscountNum(0));
                }
                books = DelBook(books);
            }

            return TotalPrice;

        }

        private double GetDiscountNum(int num)
        {
            switch(num)
            {
                case 4:
                    return 0.75;//五本折扣
                case 3:
                    return 0.8;//四本折扣
                case 2:
                    return 0.9;//三本折扣
                case 1:
                    return 0.95;//兩本折扣
                default:
                    return 1;//無折扣
            }
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

        private double Normal(List<Book> books)
        {
            return books.Sum(e => e.price);
        }

        private double Discount(List<Book> books,double discounts)
        {
            return books.Sum(e => e.price) * discounts;
        }
      
        private int BooksGroupBy(List<Book> books)
        {
            return books.GroupBy(i => i.name).Count();
        }

    }
}