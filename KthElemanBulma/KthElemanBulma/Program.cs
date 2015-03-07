using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KthElemanBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizinin n.ci elemanini bulma
            int[] array;
            int size, nth;
            Console.WriteLine("Lutfen dizi boyutunu giriniz: ");
            size = int.Parse(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write((i) + ".Sayiyi Giriniz: ");
                array[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Kacinci elemani bulalım? ");
            nth = int.Parse(Console.ReadLine());

            for (int j = 0; j < size; j++)
            {
                if (nth == j)
                {
                    nth = array[j];
                }

            }
            Console.WriteLine("Aranılan sayi: ");
            Console.WriteLine(nth);
            Console.Read();











        }
    }

}