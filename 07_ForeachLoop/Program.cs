﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1;2;3;4)
            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //     total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>(){1,2,3,4,5,8};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.Write("Sınıfında kaç öğrenci var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            //ögrenci isimlerini ve not ortalamasını saklayacak diziler.
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResault = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin{j + 1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResault += value;//notları topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResault/3;
            }
            //sınav ortalamaları
            for (int i = 0;i < studentCount; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması:{studentExamAvg[i]}");
                //Öğrencilerin geçip kalma durumları
                if ( studentExamAvg[i] >=50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti...");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı...");
                }
                Console.WriteLine("------------------------") ;
            }
            #endregion
            Console.Read();
        }
    }
}