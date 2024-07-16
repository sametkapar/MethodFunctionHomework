using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_programı
{
    internal class Lib
    {
        public string bookName;
        public string writer;
        public double rentPrc;
        public double buyPrc;


        public string AddName()
        {
            Console.WriteLine("Kitap Adını Giriniz: ");
            string addedBook = Console.ReadLine();
            return addedBook;
        }
        public string AddWrt()
        {
            Console.WriteLine("Kitap Yazar Adını Giriniz: ");
            string addedWrt = Console.ReadLine();
            return addedWrt;
        }
        public double AddRnt()
        {
            Console.WriteLine("Kiralama Fiyatını Giriniz: ");
            double addedRnt = Convert.ToDouble(Console.ReadLine());
            return addedRnt;
        }
        public double AddBuy()
        {
            Console.WriteLine("Satış Fiyatını Giriniz: ");
            double addedBuy = Convert.ToDouble(Console.ReadLine());
            return addedBuy;
        }
    }
}

