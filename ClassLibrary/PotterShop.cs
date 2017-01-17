using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class PotterShop
    {
        public PotterShop()
        {
        }

        public double CaculateMoney(List<Book> books)
        {

            if (books != null)
            {
                if(books.GroupBy(i => i.name).Count() > 2)
                {
                    return books.Count * 100 * 0.9;
                }

                else if (books.GroupBy(i => i.name).Count()>1)
                {
                    return books.Count * 100 * 0.95;
                }

                else
                {
                    return books.Count * 100;
                }

            }
            else
            {
                return 0;
            }

        }
    }
}