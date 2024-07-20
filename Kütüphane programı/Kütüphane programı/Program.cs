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

            Console.WriteLine("Kütüphaneye hoşgeldiniz giriş yapmak için kullanıcı adı ve şifrenizi giriniz.");

            #region UserValidation
            Lib a = new Lib();


            int denemeHakki = 2;

            while (denemeHakki >= 0 )
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
                string username = Console.ReadLine();
                string bosluksuz = a.BoslukSil(username);
                a.UserLogin(bosluksuz);

                if (denemeHakki == 0)
                {
                    Console.WriteLine("Hakkınız bitmiştir.");
                    
                }
                denemeHakki--;
            }

            #endregion


            #region Kitap Ekleme
            Lib[] books = new Lib[5];
            Lib book1 = new Lib();
            books[0] = book1;

            Lib book2 = new Lib();
            books[1] = book2;

            Console.WriteLine("Lütfen 5 adet Kitap ekleyiniz:");
            for (int i = 0; i < books.Length; i++)
            {

                books[i].bookName = books[i].AddName();
                books[i].writer = books[i].AddWrt();
                books[i].rentPrc = books[i].AddRnt();
                books[i].buyPrc = books[i].AddBuy();

            }

            #endregion

            #region Kitap Listesi

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + books[i].bookName + " " + books[i].writer + " " + books[i].rentPrc + " " + books[i].buyPrc + " TL");
            }

            Console.WriteLine("Alma ve ya kiralama işlemlerinden birini seçiniz:");
            string islemsecim = Console.ReadLine();

            Console.WriteLine("Hangi kitabı almak istediğinizi seçiniz: ");
            int kitapno = Convert.ToInt32(Console.ReadLine());
            


            #endregion
        }

    }
}