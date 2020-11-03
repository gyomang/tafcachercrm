using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyrosineApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ecrire votre annee");
            string lol = Console.ReadLine();
            double lol2 = Convert.ToDouble(lol);

            if (lol2 % 4 == 0)
            {
                if (lol2 % 400 != 0 && lol2 % 100 == 0)
                {
                    Console.WriteLine(lol2 + " n'est pas une annee bissextile");
                }
                else
                {
                    Console.WriteLine(lol2+" est bissextile");
                }
            }
            else
            {
                Console.WriteLine(lol2+" n'est pas une annee bissextile");
            }
           
            Console.ReadKey();
        }
    }
}
