using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tritab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ecrire une belle phrase avec un point mdr");
            string joseph = Console.ReadLine();
            string[] tab1 = joseph.Split(' ');
            int taille = tab1.Length;

            int i = 0;
            int[] tabmdr = new int[taille];
            foreach (var item in tab1)
            {
                tabmdr[i] = int.Parse(item);
                i = i + 1;
            }

            int j = 0;
            int temp = 9999999;
            int k = 0;
            foreach (var item in tabmdr)
            {
                if (item < temp)
                {
                    temp = item;
                    k = j;
                    
                }
                else if (item == temp)
                {
                    
                }

                j = j + 1;
            }

            
            Console.WriteLine(temp+"   "+k);
            

            Console.ReadKey();
        }
    }
}
