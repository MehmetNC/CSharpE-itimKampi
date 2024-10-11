using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //3+3=6+4=10+5=15+6=21 şeklinde toplama yapartüm döngüler
            //for(x,y,z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for (i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("c# Eğitim Kampı!!!");
            //}
            //Console.Read();

            //for (int i = 1; i <=20; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğinz adedi giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!!!");
            //}
            //Console.Read();

            #endregion

            #region For Döngüleri ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read();

            //int totalValue = 0;
            //for (int i = 1; i <=10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);
            //Console.Read();

            //int totalValue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i%2== 0)
            //    {  
            //        totalValue+=i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine(totalValue);
            //Console.Read();

            //int count = 0;
            //for (int i = 1; i <=50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            //Console.Read();

            //int bacterium = 1;
            //for (int i = 1; i < 24; i++)
            //{
            //    bacterium*=2;
            //    Console.WriteLine(i + ".Saat sonunda bakteri sayısı: "+bacterium);
            //}
            //Console.Read();

            #endregion

            #region While Döngüleri
            //while(şart)
            //{
            //işlemler
            //}

            //int i=1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.Read();

            //int i = 1;
            //while (i<=10)
            //{
            //    if (i%3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //Console.Read();

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum+=1;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.Read();


            #endregion

            #region Örnek Sınav Sorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan 
            //kodu giriniz.
            //Sayımız 456 olsun

            //Console.WriteLine("Sayıyı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;
            //ones = number % 10;
            //tens = (number%100) / 10;
            //hundreds=number/100;
            //Console.WriteLine(ones+"-"+tens+"-"+hundreds);

            //sum=ones+tens+hundreds;
            //Console.WriteLine(sum);
            //Console.Read();
            #endregion
        }
    }
}
