using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinavSorusu6
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] dizi = { 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1 };
            int sayac = 0;
            int maxSayac = 0;

             for (int i = 0; i < dizi.Length; i++)
            {
                
                if (dizi[i] == 0)
                {
                    
                    sayac++;
                    if (i == dizi.Length - 1)
                    {
                        if (sayac > maxSayac)
                        {
                            maxSayac = sayac;
                            sayac = 0;

                        }
                    }
                    else
                    {
                        if (sayac > maxSayac)
                        {
                            maxSayac = sayac;
                            sayac = 0;
                        }
                    }
                
               }
            }
            Console.WriteLine(maxSayac);
            Console.ReadLine();
            }

    
        }
    }

     
