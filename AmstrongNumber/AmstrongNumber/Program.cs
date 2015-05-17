using System;
using System.Collections.Generic;
using System.Text;

namespace Armstrong
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("100 ile 1000 arasındaki Amstrong Sayıları: ");

            for (int i = 100; i <= 999; i++)
            {
                int a = i / 100;
                int b = (i - a * 100) / 10;
                int c = (i - a * 100 - b * 10);

                int d = a * a * a + b * b * b + c * c * c;

                if (i == d)
                    System.Console.WriteLine("{0}", i);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}