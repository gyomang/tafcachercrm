using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recherchechaine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ecrire une belle phrase avec un point mdr");
            string joseph = Console.ReadLine();
            string[] tableauString = joseph.Split(' ');

            if (joseph == ".")
            {
                Console.WriteLine("la chaine en nul en qualitatif mdr");
            }
            else
            {
                Console.WriteLine("quel lettre voulez vous trouver ?");
                string joseph2 = Console.ReadLine();
                char[] joseph3 = joseph2.ToCharArray();
                /*char joseph4;
                foreach (var caca in joseph3)
                {
                    joseph4 = caca;
                }*/
                Console.WriteLine(joseph3[0]);

                double i = 0;
                foreach (var item in tableauString)
                {
                    foreach (var item2 in item)
                    {
                        if (item2 == joseph3[0])
                        {
                            i = i + 1;
                        }
                    }
                }
                Console.WriteLine("le " + joseph2 + " apparrait " + i + " fois");
            }
            Console.ReadKey();
        }
    }
}
