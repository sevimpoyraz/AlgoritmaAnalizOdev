using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinearRecursiveSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000];
            bool isNum = false;
            int size;

            Console.WriteLine("Dizi boyutunu giriniz: ");
            string sizeString = Console.ReadLine();
            isNum = Int32.TryParse(sizeString, out size);

            if (isNum)
            {
                Console.WriteLine("Deger giriniz: ");
                for (int i = 0; i < size; i++)
                {
                    int tempValue;
                    string arrayItem = Console.ReadLine();
                    isNum = Int32.TryParse(arrayItem, out tempValue);

                    if (isNum)
                    {
                        array[i] = tempValue;
                    }
                    else
                    {
                        Console.WriteLine("dizi boyunu aşan bir deger girdiniz!");
                        break;
                    }
                }

                Console.WriteLine("Aranılacak degeri giriniz: ");
                int searchNum;
                string searchString = Console.ReadLine();
                isNum = Int32.TryParse(searchString, out searchNum);

                if (isNum)
                {
                    int lowNum = 0;
                    int highNum = size - 1;

                   while (lowNum <= highNum)
                    {
                        int midNum = (lowNum + highNum) / 2;
                        if (searchNum < array[midNum])
                        {
                            highNum = midNum - 1;
                        }
                        else if (searchNum > array[midNum])
                        {
                            lowNum = midNum + 1;
                        }
                        else if (searchNum == array[midNum])
                        {
                            Console.WriteLine("Arama başarılı");
                            Console.WriteLine("Deger {0} bulundu {1} . sırada...\n", searchNum, midNum + 1);
                            Console.ReadLine();
                            return;
                        }
                    }
                    Console.WriteLine("Deger {0} bulunamadı! \n", searchNum);
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Aranılan deger numeric!");
                    Console.ReadLine();
                    return;
                }
            }
            else
            {
                Console.WriteLine("numeric bir deger girmelisin!");
                Console.ReadLine();
            }
            Console.ReadLine();





                }
            }
        }



