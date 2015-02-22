using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace Fibonacci_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch saat = new Stopwatch(); // stopwatch sınıfının yeni ornegini baslattı.
            Console.WriteLine("Hesaplanacak Fibonacci sayisini giriniz:");
            double  sayi = Convert.ToDouble(Console.ReadLine());
            saat.Start();  //gecen sure icin olcme islemi basladi.
            Console.WriteLine("Hesaplanan Deger:" + Fibonacci(sayi));
            saat.Stop(); //gecen sure icin olcme islemi sonlandirildi.
            TimeSpan zaman = saat.Elapsed; //stopwatch sinifinin elapsed özelliğini kullanarak gecen süre hesaplandi. 
            string elapsedTime = String.Format("{0}:{1}:{2}.{3}", zaman.Hours, zaman.Minutes, zaman.Seconds, zaman.TotalMilliseconds * 1000000); //gecen saniye milisaniye cinsinden yazilir.

            Console.WriteLine("Calisma Suresi:" + elapsedTime); // çalısma süresini ekrana yazdırıyor.
            Console.ReadLine(); // sürenin ekranda görünmesini  saglıyor.
        }

        public static double  Fibonacci(double sayi)
        {
            double first = 0, second = 1, next;

            for (double i = 0; i < sayi; i++)
            {
               
                    next = first + second;
                    first = second;
                    second = next;

                }
                return first;
            }

        }
    }
