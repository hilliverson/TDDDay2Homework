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

            if (books != null)
            {
                
                if(BooksGroupBy(books) > 4)
                {
                    //五本不同的優惠價
                    return FiveDifferentDiscount(books.Count);
                }
                else if(BooksGroupBy(books) > 3)
                {
                    //四本不同的優惠價
                    return FourDifferentDiscount(books.Count);
                }
                else if (BooksGroupBy(books) > 2)
                {
                    //三本不同的優惠價
                    return ThreeDifferentDiscount(books.Count);
                    
                }
                else if (BooksGroupBy(books) > 1)
                {
                    //兩本不同的優惠價
                    return TwoDifferentDiscount(books.Count);
                    
                }
                else
                {
                    //一般價格
                    return Normal(books.Count);
                }
            }
            else
            {
                return 0;
            }

        }

        private double FiveDifferentDiscount(int num)
        {
            return num * _potterPrice * 0.75;
        }

        private double Normal(int num)
        {
            return num * _potterPrice;
        }

        private double TwoDifferentDiscount(int num)
        {
            return num * _potterPrice * 0.95;
        }

        private double ThreeDifferentDiscount(int num)
        {
            return num * _potterPrice * 0.9;
        }

        private int BooksGroupBy(List<Book> books)
        {
            return books.GroupBy(i => i.name).Count();
        }

        private double FourDifferentDiscount(int num)
        {
            return num * _potterPrice * 0.8;
        }
    }
}