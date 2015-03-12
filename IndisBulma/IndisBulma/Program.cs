using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndisBulma
{
    class Program  //dizinin n. en buyuk elemanini bulma
    {
        static void KthIndexBulma(int[] array, int nth) //kucukten buyuge bubble sort 
        {
            int temp;
            for (int i = 0; i < array.Length ; i++)
           {
               for (int j = i + 1; j < array.Length; j++)
               {
                   if (array[j] < array[i])
                   {
                       temp = array[j];
                       array[j] = array[i];
                       array[i] = temp;
                   }
               }
           }
            for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "-"); //dizinin sirali hali
            Console.WriteLine("\nAranilan sayi: " + array[nth - 1]);


          
           

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
            Console.Write("kacinci elemanı bulalım?: ");
            int nth = Convert.ToInt32(Console.ReadLine());
            KthIndexBulma(array, nth);

            Console.ReadLine();

        }

    }
}