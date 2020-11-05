using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definirclasse
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

            double ij = 0;
            double iv = 0;
            double ia = 0;
            foreach (var item in tableauDouble)
            {
                if (item < 20)
                {
                    ij++;
                }
                else if(item > 20)
                {
                    iv++;
                }
                else if (item == 20)
                {
                    ia++;
                }
                else
                {
                    Console.WriteLine("dook dook dooooooooooooook");
                }
            }

            if (iv + ia == 0)
            {
                Console.WriteLine("il n'y a que des jeunes babadook");
            }
            else if (ij == 0)
            {
                Console.WriteLine("il n'y a que des vieux babadook");
            }
            else
            {
                Console.WriteLine("il y a "+ij+" gosses, "+iv+" vieux, et "+ia+" darkrebels");
            }

            Console.ReadKey();
        }
    }
}
