using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vicApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("alors exo a ou autre");
            string lol = Console.ReadLine();
            if (lol == "a")
            {

                /*=======================*/


                Console.WriteLine("A");
                double A = double.Parse(Console.ReadLine());
                Console.WriteLine("B");
                double B = double.Parse(Console.ReadLine());

                double prems = 0;
                double deus = 0;

                if (A > B)
                {
                    prems = A;
                    deus = B;
                }
                else if (B > A)
                {
                    prems = B;
                    deus = A;
                }

                Console.WriteLine("------ " + prems + " > " + deus + " -------");
            }
            else
            {

            

            

            /*---------------------------*/

            /*
            Console.WriteLine("rentrer des nombres separés par des espace");
            string joseph = Console.ReadLine();
            string[] tabwords = joseph.Split(' ');

            int i = 0;
            int j = 1;
            foreach (var calc in tabwords)
            {
                foreach (var item in tabwords)
                {
                    if (calc2 > item2)
                    {
                        double popo = calc2;
                        tabwords[i] = item2;
                        tabwords[j] = popo;
                    }
                    j = j + 1;
                }
                i = i + 1;  
            }
            */

            /*-----------------------------*/

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


            /*int i = 0;
            int j = 0;
            foreach (var calc in tableauDouble)
            {
                foreach (var item in tableauDouble)
                {
                    if (calc > item)
                    {
                        double popo = calc;
                        tableauDouble[i] = item;
                        tableauDouble[j] = popo;
                    }
                    j = j + 1;
                }
                i = i + 1;
            }*/

            Array.Sort(tableauDouble);

            foreach (var i in tableauDouble)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadLine();

            /*----------------------------*/

            Console.WriteLine(tableauDouble[1]);

            }

            Console.ReadKey();

        }
    }
}
