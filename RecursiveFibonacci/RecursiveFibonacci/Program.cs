using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Fibanacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch saat = new Stopwatch(); //stopwatch sinifinin yeni bir ornegini baslatir.
            double sayi;
            Console.Write("Hesaplanacak Fibonacci sayisini giriniz: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            saat.Start(); //hesaplama icin sureyi baslatir.
            Console.WriteLine("" + Fibonacci(sayi));
            saat.Stop(); // hesaplama icin sureyi sonlandirir.
            TimeSpan zaman = saat.Elapsed; //ornek icin gecen toplam sureyi alir.
            Console.WriteLine("{0}:{1}:{2}.{3}", zaman.Hours, zaman.Minutes, zaman.Seconds, zaman.TotalMilliseconds * 1000000);
          //  Console.WriteLine("Toplam milisaniye : " + zaman.TotalMilliseconds); // Hesaplanan sureyi milisaniye olarak gosterir.
            Console.ReadLine(); //ciktinin ekranda gorunmesini saglar




        }
        static double Fibonacci(double sayi)
        {
            if (sayi== 0)
                return 0;
            else if (sayi == 1)
                return 1;
            else
                return (Fibonacci(sayi - 1) + Fibonacci(sayi- 2));
        }
    }
}
