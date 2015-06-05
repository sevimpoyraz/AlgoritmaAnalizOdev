using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinavSorusu8
{
    class Program
    {
     
        static void Main(string[] args)
        {
            int[] array;
            int size;
            int newSize;
            Console.WriteLine("Kac elemanli dizi olsun: ");
            size = int.Parse(Console.ReadLine());
            array = new int[size];

            newSize = array.Length * 2;

            Random random= new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100);
               
                Console.Write(" {0}", array[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Dizinin tersten yazilmis hali: ");
            for (int i = size; i > 0; i--)
            {
                Console.Write(" {0}", array[i - 1]);


            }



                Console.ReadLine();

        }
    }
}
