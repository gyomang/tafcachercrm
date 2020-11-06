using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ecrire une belle phrase avec un point mdr");
            string joseph = Console.ReadLine();
            joseph = joseph.Replace(" ", string.Empty);

            int k = 0;
            char[] tabchar = new char[joseph.Length];
            foreach (var item2 in joseph)
            {
                tabchar[k]=item2;
                k++;
            }

            int i = 0;
            int j = tabchar.Length-1;
            char[] invers = new char[tabchar.Length];
            foreach (var item in tabchar)
            {
                invers[i] = tabchar[j];
                i++;
                j = j - 1;
            }

            //foreach (var item3 in tabchar)
            //{
            //    Console.WriteLine(item3);
            //}
            //foreach (var item in invers)
            //{
            //    Console.WriteLine(item);
            //}

            bool lol = true;
            int l = 0;
            foreach (var item in tabchar)
            {
                if (invers[l] != tabchar[l])
                {
                    lol = false;
                }
            }

            if (lol == false)
            {
                Console.WriteLine("palindrome not detected");
            }
            else if (lol == true)
            {
                Console.WriteLine("palindrome detected and destroyed");
            }
            else
            {
                Console.WriteLine("wtf paladin");
            }
            
            
            Console.ReadKey();
        }
    }
}
