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
            Console.WriteLine("ecrire des chiffre separer par espace");
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

            //on as un tab de chifferela des cancrela//^_^//

            int j = 0;
            int temp = 9999999;
            int k = 0;
            int z = 0;
            foreach (var item2 in tabmdr)
            {
                temp = 9999999;
                j = 0;
                foreach (var item in tabmdr)
                {
                    if (j>=z)
                    {
                        if (item < temp)
                        {
                            temp = item;
                            k = j;
                            //Console.WriteLine("test"+k);

                        }
                    }
                    j = j + 1;
                }

                //Console.WriteLine(temp+"   "+k);

                int morgul = tabmdr[k];
                tabmdr[k] = tabmdr[z];
                tabmdr[z] = morgul;
                //Console.WriteLine("info" + z);

                z = z + 1;
            }

            Console.WriteLine("En ordre");
            foreach (var item in tabmdr)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
