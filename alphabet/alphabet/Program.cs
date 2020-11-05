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
            joseph = joseph.Replace(" ", "");

            //char [] josephchar = joseph.ToCharArray();

            int[] tabmdr = new int[26];

            string[] tablol0 = new string[26] {
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
            };
            
            char[] tablol0char = new char[26];
            int i = 0;
            foreach (var item in tablol0)
            {
                foreach (var item2 in item)
                {
                    tablol0char[i] = item2;
                }
                
                i = i + 1;
            }

            /*char[] tablolchar = new char[26] {
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
            };*/

            /*string[,] tablol = new string[2,26] {
                {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"},{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
            };*/

            //double j = joseph.Length;



            foreach (var item in joseph)
            {
                foreach (var lol in tablol0char)
                {
                    //Console.WriteLine(item + " et  " + lol);
                    if (item.Equals(lol))
                    {
                        //Console.WriteLine(item+" comme  "+lol);
                        int placelol = Array.IndexOf(tablol0char, item);
                        tabmdr[placelol] = tabmdr[placelol] + 1;
                        //Console.WriteLine(tabmdr[placelol]);
                    }
                }
            }

            int k = 0;
            foreach (var nb in tabmdr)
            {
                if (nb > 0)
                {
                    Console.WriteLine("la lettre '" + tablol0[k] + "' obtient " + nb + " occurence");
                }
                k = k + 1;
            }
            
            Console.ReadKey();
        }
    }
}
