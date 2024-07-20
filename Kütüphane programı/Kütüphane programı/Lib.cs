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


        #region İşlemler


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
        #endregion

        #region Kullanıcı giris kontrol
        public void UserLogin(string username)
        {

            if (username == "admin")
            {
                Console.WriteLine("Şifrenizi Giriniz: ");
                string password = Console.ReadLine();
                string bosluksuzSifre = BoslukSil(password);
                UserLoginPassword(bosluksuzSifre);
                return;
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı Yanlış");

                return;
            }
        }

        public void UserLoginPassword(string password)
        {
            if (password == "1234")
            {

                Console.WriteLine("Giriş Başarılı!");
                return;
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");

                return;
            }

        }
        #endregion
 
        #region Bosluk silme
        public string BoslukSil(string metin)
        {
            int index = -1;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != ' ')
                {
                    index = i;
                    break;

                }
            }
            string yenimetin = "";
            for (int i = index; i < metin.Length; i++)
            {
                yenimetin += metin[i];
            }
            return yenimetin;
            #endregion
        }
    }
}

