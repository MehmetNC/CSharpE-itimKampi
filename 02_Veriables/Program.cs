using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.Read();

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("----Elmanın Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("----Portakalın Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("----Çileğin Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("----Patatesin Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("----Domatesin Fiyatı:" + tomatoPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine();
            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //double total = 0;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //total=appleGram*applePrice+orangeGram*orangePrice+strawberryGram*strawberryPrice+
            //    potatoGram*potatoPrice+tomatoGram*tomatoGram;

            //Console.WriteLine("Toplam tutar:"+total+"TL");
            //Console.Read();

            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CShar Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcunun Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcunun T.C.'si: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //Console.WriteLine("Yolcunun T.C.'si: "+passengerIdentityNumber+" Yolcu: " + passengerName + " " + passengerSurname+" "+
            //    passengerDistrict+"/"+passengerCity+" "+passengerAge);



            //Console.Read();

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPraice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPraice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayyakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());//parse dönüşüm yapar

            //Console.Write("Lütfen almış olduğunuz bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            //tvCount=int.Parse(Console.ReadLine());

            //int totalPrice=shoesPrice*shoesCount+computerPrice*computerCount+chairPraice*chairCount+
            //    tvPrice*tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Ödenecek Tutar: " + totalPrice);
            //Console.Read();

            #endregion

            #region Klavyeden Ondalıklı sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.WriteLine("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 =double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 =double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: "+result);
            //Console.Read();


            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen bir cinsiyet seçiniz: ");
            gender=char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Seçtiğiniz cinsiyet: "+gender);
            Console.Read();

            #endregion
        }
    }
}
