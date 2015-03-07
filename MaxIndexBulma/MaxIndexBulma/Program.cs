using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxIndexBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizinin en buyuk elemanını bulma
            int[] array;
            int size;
            Console.WriteLine("Lutfen dizi boyutunu giriniz: ");
            size = int.Parse(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write((i + 1) + ".Sayiyi Giriniz: ");
                array[i] = int.Parse(Console.ReadLine());
            
            }

            int largest = array[array.Length-1];
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > largest)
                {
                    largest = array[i];

                }
            }
            Console.WriteLine("dizinin en buyuk elemanı: {0}", largest);
            Console.Read();

        }
    }
}
