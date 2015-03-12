using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnBuyukEleman
{
    class Program       //dizinin en buyuk elemanini bulma 
    {
        static void MaxElemanBulma(int[] array)
        {
            int largest = array[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                }
            }
            Console.WriteLine("Dizinin en buyuk elemani: {0}", largest);
            Console.Read();
        }



        static void Main(string[] args)
        {
            int[] array;
            int size;
            Console.WriteLine("Lutfen dizi boyutunu giriniz: ");
            size = int.Parse(Console.ReadLine());
            array = new int[size];
            Random random = new Random(); //
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100); // dizi elemanlarina 1 ve 100 arasinda deger atiyor
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + "-");
            }


            Console.WriteLine();
            MaxElemanBulma(array);
            Console.Read();


        }
    }
}
