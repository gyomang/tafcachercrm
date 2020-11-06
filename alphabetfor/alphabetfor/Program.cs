using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ecrire une belle phrase avec un point mdr");
            string joseph = Console.ReadLine();
            joseph = joseph.Replace(" ", string.Empty);

            int[] tabmdr = new int[26];
            for (int i = 0; i < tabmdr.Length; i++)
            {
                tabmdr[i] = 0;
            }

            //for (int l = 0; l < tabmdr.Length; l++)
            //{
            //    Console.Write(tabmdr[l]+"\t");
            //}
            
            char[] alpha = new char[26];

            char test= 'a';
           for (int i =0; i < alpha.Length; i++)
            {
                alpha[i] =test ;
                test++;
            }

            //for (int l = 0; l < alpha.Length; l++)
            //{
            //    Console.Write(alpha[l] + "\t");
            //}

            for (int i = 0; i < joseph.Length; i++)
            {
                char lettre = joseph[i];

                for (int j = 0; j < alpha.Length; j++)
                {
                    if (lettre.CompareTo(alpha[j])==0)
                    {
                        tabmdr[j]++;
                    }
                }
            }

            for (int m = 0; m < tabmdr.Length; m++)
            {
                if (tabmdr[m] != 0)
                {
                    Console.WriteLine("la lettre "+alpha[m]+" est presente : "+tabmdr[m]);
                }
            }
           
            Console.ReadKey();
        }
    }
}
