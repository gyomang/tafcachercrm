using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reconnaitreintab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rentrer des nombres separés par des espace");
            string joseph = Console.ReadLine();
            string[] tableauString = joseph.Split(' ');

            int taille = tableauString.Length;
            double[] tableauDouble = new double[taille];
            int compteur = 0;
            foreach (string element in tableauString)
            {
                tableauDouble[compteur] = Convert.ToDouble(element);
                compteur++;
            }
            Array.Sort(tableauDouble);

            Console.WriteLine("quel nombre voulez vous trouver ? si vous le voulez bien mdr");
            string joseph2 = Console.ReadLine();
            double joseph3 = Convert.ToDouble(joseph2);

            double trouver = 0;
            foreach (var item in tableauDouble)
            {
                if (item == joseph3)
                {
                    trouver = 1;

                }
                else
                {
                    trouver = 0;
                }
            }

            if (trouver == 1)
            {
                Console.WriteLine("il existe quel chanceux");
            }
            else
            {
                Console.WriteLine("non trouver vous me faite perdre mon temps mdr");
            }

            Console.ReadKey();
        }
    }
}
