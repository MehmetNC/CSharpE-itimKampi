using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.Read();
            #endregion
            #region string Değişkenler
            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Mehmet nur Ceylan";
            //Console.WriteLine(name);
            //Console.Read();

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Mehmet nur";
            //customerSurname = "Ceylan";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "@sglmsvşwv.gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("***** Rezarvasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: "+ customerName+" "+customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone+" "+customerEmail);
            //Console.WriteLine("Adres: "+city+"/"+district);
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();
            //customerName = "Cemre nur";
            //customerSurname = "Orak";
            //customerPhone = "+90 500 300 20 10";
            //customerEmail ="@kaflskdkslkd.gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone + " " + customerEmail);
            //Console.WriteLine("Adres: " + city + "/" + district);
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("***** Rezarvasyon Kartı *****");
            //Console.Read();


            #endregion
            #region ınt Değişkenler
            //int number=24;
            //Console.WriteLine(number);

            int hamburgerPrice=300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----Hamburger: "+hamburgerPrice+"TL");
            Console.WriteLine("-----Kola: "+cokePrice+"TL");
            Console.WriteLine("-----Su: "+waterPrice+"TL");
            Console.WriteLine("-----Kızartma: "+friesPrice+"TL");
            Console.WriteLine("-----Pizza: "+pizzaPrice+"TL");
            Console.WriteLine("-----Limonata: "+lemonadePrice+"TL");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fyatı *****");
            

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalPrice = hamburgerCount * hamburgerPrice+cokeCount*cokePrice+
            waterCount*waterPrice+friesCount*friesPrice+pizzaCount*pizzaPrice+
            lemonadeCount*lemonadePrice;

            Console.WriteLine("Hesap: "+totalPrice);
            Console.Read();
            
            #endregion
        }
    }
}
