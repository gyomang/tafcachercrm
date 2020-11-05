using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace km
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("veuillez saisir des km pour miles");
            double nombre;
            bool testnb = true;
            string joseph = Console.ReadLine().ToLower();

            testnb = double.TryParse(joseph, out nombre);
            string souschaine = joseph.Substring(joseph.Length-2);
            nombre = double.Parse( joseph.Substring(0,joseph.Length - 3));

            if (testnb == true)
            {

            }
            else
            {
                if (souschaine == "mi")
                {
                    nombre = nombre * 1.609;
                    Console.WriteLine("la distance en km = "+Math.Round(nombre,3));
                }
                else if (souschaine == "km")
                {
                    nombre = nombre % 1.609;
                    Console.WriteLine("la distance en mi = " + Math.Round(nombre, 3));
                }
                else
                {
                    Console.WriteLine("conversion imposs des impot");
                }
            }

            Console.ReadKey();
        }   
    }
}
