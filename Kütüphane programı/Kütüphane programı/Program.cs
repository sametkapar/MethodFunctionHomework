using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_programı
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Kital Ekleme
            Lib[] books =new Lib[2];
            Lib book1 = new Lib();
            books[0] = book1;

            Lib book2 = new Lib();
            books[1] = book2;
            bool devam = true;
            while (devam == true)
            {
                for (int i = 0; i < books.Length; i++)
                {

                    books[i].bookName = books[i].AddName();
                    books[i].writer = books[i].AddWrt();
                    books[i].rentPrc = books[i].AddRnt();
                    books[i].buyPrc = books[i].AddBuy();

                }
                Console.WriteLine("Kitap eklemeye devam etmek istiyormusunuz? e/h");
                string cvp = Console.ReadLine();
                if (cvp == "e")
                {
                    devam = true;
                    
                }
                else
                { 
                    devam = false;
                }
            }
            #endregion

            #region Kitap Listesi

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + books[i].bookName + " " + books[i].writer + " " + books[i].rentPrc + " " + books[i].buyPrc + " TL");
            }
            #endregion
        }

    }
}