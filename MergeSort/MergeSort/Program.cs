using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace MergeSort
{
    class Program
    {
        public static void Sort(int[] data, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(data, left, middle);
                Sort(data, middle + 1, right);
                Merge(data, left, middle, middle + 1, right);
            }
        }
        public static void Merge(int[] data, int left, int middle, int middle1, int right)
        {
            int oldPosition = left;
            int size = right - left + 1;
            int[] temp = new int[size];
            int i = 0;

            while (left <= middle && middle1 <= right)
            {
                if (data[left] <= data[middle1])
                    temp[i++] = data[left++];
                   
                
                else
                    temp[i++] = data[middle1++];
                
            }
            if (left > middle)
                for (int j = middle1; j <= right; j++)
                    temp[i++] = data[middle1++];
                
            
            else
                for (int j = left; j <= middle; j++)
                    temp[i++] = data[left++];
                Array.Copy(temp, 0, data, oldPosition, size);
            
           
        }

        public static void Main(String[] args)
        {
            Console.Title ="MERGE SORT";
            int i;
            Console.WriteLine("Dizi boyutunu giriniz: ");
            int diziboyutu = int.Parse(Console.ReadLine());

            Random myRandom = new Random();
            Stopwatch myTime = new Stopwatch();
            int[] data = new int[diziboyutu] ;

            for (i = 0; i < diziboyutu; i++)
            {
                data[i] = myRandom.Next(100);
            }
            Console.WriteLine("Dizinin sıralanmamış hali: ");
            for (i = 0; i < diziboyutu; i++)
            {
                Console.Write(" {0}", data[i]);
            }
            Console.WriteLine();
            myTime.Start();
            Sort(data, 0, data.Length - 1);
            myTime.Stop();

            string TimeEl = myTime.Elapsed.ToString();

            Console.WriteLine("Dizinin sıralı hali: ");
            for ( i = 0; i < diziboyutu; i++)
            {
                Console.Write(" {0} ",data[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("time elapsed: {0} ",TimeEl);
            Console.ReadLine();
        }
    }
           
         
    
}
