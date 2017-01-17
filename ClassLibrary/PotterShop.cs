using System;

namespace ClassLibrary
{
    public class PotterShop
    {
        public PotterShop()
        {
        }

        public int CaculateMoney(string book)
        {
            if(book.Equals("Potter1")|| book.Equals("Potter2")|| book.Equals("Potter3")|| book.Equals("Potter4")|| book.Equals("Potter5"))
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }
    }
}