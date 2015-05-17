using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class Program
    {
       static public int Partition(int [] numbers, int left, int right)
        {
            int pivot = numbers[left];
              while (true)
              {
                while (numbers[left] < pivot)
                    left++;
 
                while (numbers[right] > pivot)
                    right--;
 
                if (left < right)
                    {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                    }
                    else
                    {
                          return right;
                    }
              }
        }
 
        static public void QuickSort_Recursive(int [] arr, int left, int right)
        {
            // For Recusrion
            if(left < right)
            {
                int pivot = Partition(arr, left, right);
 
                if(pivot > 1)
                    QuickSort_Recursive(arr, left, pivot - 1);
 
                if(pivot + 1 < right)
                    QuickSort_Recursive(arr, pivot + 1, right);
            }
        }
 
        static void Main(string[] args)
        {
            int[] array;
            int size;
            Console.WriteLine("Lutfen dizi boyutu giriniz: ");
            size = int.Parse(Console.ReadLine());

            array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100); // dizi elemanlarina 1 ve 100 arasinda deger atiyor
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + "-");
            }

 
            Console.WriteLine("QuickSort By Recursive Method");
            QuickSort_Recursive(array, 0, size - 1);
            for (int i = 0; i < size; i++)
                Console.WriteLine(array[i]);
 
            Console.WriteLine();
            Console.ReadLine();
           
        }
    }
}
 
