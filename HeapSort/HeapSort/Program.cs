using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace HeapSort
{
    class Program
    {

        public static void Adjust(int[] list, int i, int m)
        {
            int Temp = list[i];
            int j = i * 2 + 1;

            while (j <= m)
            {

                if (j < m)
                    if (list[j] < list[j + 1])
                        j = j + 1;


                if (Temp < list[j])
                {
                    list[i] = list[j];
                    i = j;
                    j = 2 * i + 1;
                }
                else
                {
                    j = m + 1;
                }
            }

            list[i] = Temp;
        }





        public static void HeapSort(int[] list)
        {
            int i;
            for (i = (list.Length - 1) / 2; i >= 0; i--)
                Adjust(list, i, list.Length - 1);

            for (i = list.Length - 1; i >= 1; i--)
            {
                int Temp = list[0];
                list[0] = list[i];
                list[i] = Temp;
                Adjust(list, 0, i - 1);
            }


        }

        static void Main(string[] args)
        {
            Console.Title = "HEAP SORT";
            int i;
            Console.WriteLine("Dizi boyutunu giriniz: ");
            int diziboyutu = int.Parse(Console.ReadLine());

            Random myRandom = new Random();
            Stopwatch myTime = new Stopwatch(); 




            int[] a = new int[diziboyutu];


            for (i = 0; i < diziboyutu; i++)
            {
                a[i] = myRandom.Next(100);
            }
            Console.WriteLine("Dizinin sıralanmamış hali:  ");
            for (i = 0; i <diziboyutu; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
            Console.WriteLine();
            myTime.Start();
            HeapSort(a);
            myTime.Stop();

            string TimeEl = myTime.Elapsed.ToString();

            Console.WriteLine("Dizinin sıralanmış: ");
            for (i = 0; i < diziboyutu; i++){
                Console.Write(" {0} ", a[i]);
                }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("time elapsed: {0} ", TimeEl);
            Console.ReadLine();




        }


    }
}