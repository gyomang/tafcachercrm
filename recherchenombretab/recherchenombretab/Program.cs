using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recherchenombretab
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

            double i = 0;
            foreach (var item in tableauDouble)
            {
                if (item < 20)
                {
                    i = i + 1;
                }   
            }

            Console.WriteLine("il y a "+i+" jeunes au mordor");
            Console.ReadKey();
        }
    }
}
